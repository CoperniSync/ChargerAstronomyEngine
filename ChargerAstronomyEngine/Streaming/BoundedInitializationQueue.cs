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
    public sealed class BoundedInitializationQueue<T> : BlockingQueue<T>, IDisposable
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

        /// <inheritdoc />
        public IProducerConsumerCollection<T> Collection => inner;

        /// <inheritdoc />
        public int Capacity { get; }

        /// <inheritdoc />
        public int Count => blocking.Count;

        /// <inheritdoc />
        public bool TryEnqueue(T item) => blocking.TryAdd(item, 0);

        /// <inheritdoc />
        public void EnqueueBlocking(T item, CancellationToken ct) => blocking.Add(item, ct);


        /// <inheritdoc />
        public bool TryDequeue(out T item) => blocking.TryTake(out item, 0);

        /// <inheritdoc />
        public void Complete()
        {
            if (Interlocked.Exchange(ref completed, 1) == 0)
                blocking.CompleteAdding();
        }

        /// <inheritdoc />
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
