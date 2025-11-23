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

The maximum capacity of the queue.

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

The current count of items in the queue.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_IsCompleted"></a> IsCompleted

States whether the queue has been marked complete and is fully drained.

```csharp
public bool IsCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_Complete"></a> Complete\(\)

Signals that no more items will be added to the queue.

```csharp
public void Complete()
```

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_Dispose"></a> Dispose\(\)

Dumps the queue, releasing all used resources.

```csharp
public void Dispose()
```

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_EnqueueBlocking__0_System_Threading_CancellationToken_"></a> EnqueueBlocking\(T, CancellationToken\)

Attempt to enqueue an item, blocking until space is available or cancellation is requested. Blocked items will be added once space is made.

```csharp
public void EnqueueBlocking(T item, CancellationToken ct)
```

#### Parameters

`item` T

`ct` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_TryDequeue__0__"></a> TryDequeue\(out T\)

Attempt to dequeue an item. If the queue is empty, returns false.

```csharp
public bool TryDequeue(out T item)
```

#### Parameters

`item` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="ChargerAstronomyEngine_Streaming_BoundedInitializationQueue_1_TryEnqueue__0_"></a> TryEnqueue\(T\)

Attempt to enqueue an item without blocking. If the queue is full, returns false.

```csharp
public bool TryEnqueue(T item)
```

#### Parameters

`item` T

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

