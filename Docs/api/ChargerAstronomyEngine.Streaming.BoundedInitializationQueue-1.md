# <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1"></a> Class BoundedInitializationQueue<T\>

Namespace: [ChargerAstronomyEngine.Streaming](ChargerAstronomyEngine.Streaming.md)  
Assembly: ChargerAstronomyEngine.dll  

Instance of a bounded initialization queue. Mason found this online and made a few modifications.

```csharp
public sealed class BoundedInitializationQueue<T> : BlockingQueue<T>, IDisposable
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BoundedInitializationQueue<T\>](ChargerAstronomyEngine.Streaming.BoundedInitializationQueue\-1.md)

#### Implements

[BlockingQueue<T\>](ChargerAstronomyShared.Contracts.Streaming.BlockingQueue\-1.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1__ctor_System_Int32_"></a> BoundedInitializationQueue\(int\)

```csharp
public BoundedInitializationQueue(int capacity)
```

#### Parameters

`capacity` [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_Capacity"></a> Capacity

The total amount of items that can be held in the queue.

```csharp
public int Capacity { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_Collection"></a> Collection

The collection of items to be queued.

```csharp
public IProducerConsumerCollection<T> Collection { get; }
```

#### Property Value

 [IProducerConsumerCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.iproducerconsumercollection\-1)<T\>

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_Count"></a> Count

The current amount of items that are in the queue.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_IsCompleted"></a> IsCompleted

Marks whether the queue has been marked complete and is fully drained.

```csharp
public bool IsCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_Complete"></a> Complete\(\)

Marks that the producer will not add more items to the queue. There may still be items left to dequeue.

```csharp
public void Complete()
```

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_Dispose"></a> Dispose\(\)

Dumps the queue, releasing all used resources.

```csharp
public void Dispose()
```

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_EnqueueBlocking__0_System_Threading_CancellationToken_"></a> EnqueueBlocking\(T, CancellationToken\)

Adds an item to the queue, blocking if the queue is full until space becomes available or the operation is
canceled.

```csharp
public void EnqueueBlocking(T item, CancellationToken ct)
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

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_TryDequeue__0__"></a> TryDequeue\(out T\)

Attempts to remove and return the item at the beginning of the queue.

```csharp
public bool TryDequeue(out T item)
```

#### Parameters

`item` T

When this method returns, contains the object removed from the queue.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if an object was successfully removed from the queue; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_TryEnqueue__0_"></a> TryEnqueue\(T\)

Attempts to add the item to the queue.

```csharp
public bool TryEnqueue(T item)
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

