using System;
using System.Collections.Concurrent;
using System.Threading;
using ChargerAstronomyShared.Contracts.Streaming;

namespace ChargerAstronomyEngine.Streaming
{
    // using implementation found online, with some modifications
    // this is really just a wrapper class

    /// <summary>
    /// Instance of a bounded initialization queue. Mason found this online and made a few modifications.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class BoundedInitializationQueue<T> : IInitializationQueue<T>, IDisposable
    {
        readonly ConcurrentQueue<T> inner;
        readonly BlockingCollection<T> blocking;
        int completed; 

        public BoundedInitializationQueue(int capacity)
        {
            if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            inner = new ConcurrentQueue<T>();
            blocking = new BlockingCollection<T>(inner, capacity);
            Capacity = capacity;
        }

        public IProducerConsumerCollection<T> Collection => inner;

        /// <summary>
        /// The maximum capacity of the queue.
        /// </summary>
        public int Capacity { get; }

        /// <summary>
        /// The current count of items in the queue.
        /// </summary>

        public int Count => blocking.Count;

        /// <summary>
        /// Attempt to enqueue an item without blocking. If the queue is full, returns false.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool TryEnqueue(T item) => blocking.TryAdd(item, 0);

        /// <summary>
        /// Attempt to enqueue an item, blocking until space is available or cancellation is requested. Blocked items will be added once space is made.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="ct"></param>
        public void EnqueueBlocking(T item, CancellationToken ct) => blocking.Add(item, ct);


        /// <summary>
        /// Attempt to dequeue an item. If the queue is empty, returns false.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool TryDequeue(out T item) => blocking.TryTake(out item, 0);

        /// <summary>
        /// Signals that no more items will be added to the queue.
        /// </summary>
        public void Complete()
        {
            if (Interlocked.Exchange(ref completed, 1) == 0)
                blocking.CompleteAdding();
        }

        /// <summary>
        /// States whether the queue has been marked complete and is fully drained.
        /// </summary>
        public bool IsCompleted => blocking.IsAddingCompleted && inner.IsEmpty || blocking.IsCompleted;

        /// <summary>
        /// Dumps the queue, releasing all used resources.
        /// </summary>
        public void Dispose()
        {
            Complete();
            blocking.Dispose();
        }
    }
}
