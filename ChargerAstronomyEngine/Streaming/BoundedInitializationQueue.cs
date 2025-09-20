using System;
using System.Collections.Concurrent;
using System.Threading;
using ChargerAstronomyShared.Contracts.Streaming;

namespace ChargerAstronomyEngine.Streaming
{
    // using implementation found online, with some modifications
    // this is really just a wrapper class

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

        public int Capacity { get; }

        public int Count => inner.Count;

        public bool TryEnqueue(T item) => blocking.TryAdd(item, 0);

        public void EnqueueBlocking(T item, CancellationToken ct) => blocking.Add(item, ct);

        public bool TryDequeue(out T item) => inner.TryDequeue(out item);

        public void Complete()
        {
            if (Interlocked.Exchange(ref completed, 1) == 0)
                blocking.CompleteAdding();
        }

        public bool IsCompleted => blocking.IsAddingCompleted && inner.IsEmpty;

        public void Dispose()
        {
            Complete();
            blocking.Dispose();
        }
    }
}
