# <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1"></a> Interface BlockingQueue<T\>

Namespace: [ChargerAstronomyShared.Contracts.Streaming](ChargerAstronomyShared.Contracts.Streaming.md)  
Assembly: ChargerAstronomyShared.dll  

A thread-safe blocking queue interface for managing a collection of items with blocking enqueue and dequeue operations.

```csharp
public interface BlockingQueue<T>
```

#### Type Parameters

`T` 

The objects to be passed through the queue.

## Properties

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_Capacity"></a> Capacity

The total amount of items that can be held in the queue.

```csharp
int Capacity { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_Collection"></a> Collection

The collection of items to be queued.

```csharp
IProducerConsumerCollection<T> Collection { get; }
```

#### Property Value

 [IProducerConsumerCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.iproducerconsumercollection\-1)<T\>

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_Count"></a> Count

The current amount of items that are in the queue.

```csharp
int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_IsCompleted"></a> IsCompleted

Marks whether the queue has been marked complete and is fully drained.

```csharp
bool IsCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_Complete"></a> Complete\(\)

Marks that the producer will not add more items to the queue. There may still be items left to dequeue.

```csharp
void Complete()
```

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_EnqueueBlocking__0_System_Threading_CancellationToken_"></a> EnqueueBlocking\(T, CancellationToken\)

Adds an item to the queue, blocking if the queue is full until space becomes available or the operation is
canceled.

```csharp
void EnqueueBlocking(T item, CancellationToken ct)
```

#### Parameters

`item` T

The item to add to the queue.

`ct` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A <xref href="System.Threading.CancellationToken" data-throw-if-not-resolved="false"></xref> that can be used to cancel the operation.

#### Remarks

This method blocks the calling thread if the queue is full, waiting until space
    becomes available. Ensure that the <code class="paramref">ct</code> token is monitored to avoid indefinite blocking in
    scenarios if cancellation is required.

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_TryDequeue__0__"></a> TryDequeue\(out T\)

Attempts to remove and return the item at the beginning of the queue.

```csharp
bool TryDequeue(out T item)
```

#### Parameters

`item` T

When this method returns, contains the object removed from the queue.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if an object was successfully removed from the queue; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_1_TryEnqueue__0_"></a> TryEnqueue\(T\)

Attempts to add the item to the queue.

```csharp
bool TryEnqueue(T item)
```

#### Parameters

`item` T

The item to add to the queue.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the item was successfully added to the queue; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

#### Remarks

Note this method does not throw an exception if the operation fails. The caller can use
    the return value to determine whether the item was enqueued successfully.

