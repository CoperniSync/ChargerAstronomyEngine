using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using FluentAssertions;
using System.Runtime.CompilerServices;

using ChargerAstronomyEngine.Data;
using ChargerAstronomyEngine.Streaming;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Domain.Equatorial;

namespace tests
{
    public class InitializationQueueTest
    {
        [Fact]
        public void EnqueueBlocking_ShouldAddItemsToQueue()
        {
            // Arrange
            var queue = new BoundedInitializationQueue<int>(5);

            // Act
            queue.EnqueueBlocking(1, CancellationToken.None);
            queue.EnqueueBlocking(2, CancellationToken.None);

            // Assert
            queue.Count.Should().Be(2);
        }

        [Fact]
        public void TryDequeue_ShouldRemoveItemsFromQueue()
        {
            // Arrange
            var queue = new BoundedInitializationQueue<int>(5);
            queue.EnqueueBlocking(1, CancellationToken.None);
            queue.EnqueueBlocking(2, CancellationToken.None);

            // Act
            var success1 = queue.TryDequeue(out var item1);
            var success2 = queue.TryDequeue(out var item2);

            // Assert
            success1.Should().BeTrue();
            item1.Should().Be(1);
            success2.Should().BeTrue();
            item2.Should().Be(2);
            queue.Count.Should().Be(0);
        }

        [Fact]
        public void Complete_ShouldMarkQueueAsCompleted()
        {
            // Arrange
            var queue = new BoundedInitializationQueue<int>(5);

            // Act
            queue.Complete();

            // Assert
            queue.IsCompleted.Should().BeTrue();
        }

        [Fact]
        public void Complete_ShouldPreventItemsBeingAdded()
        {
            // Arrange
            var queue = new BoundedInitializationQueue<int>(5);
            queue.Complete();

            // Act
            Action act = () => queue.EnqueueBlocking(1, CancellationToken.None);

            // Assert
            act.Should().Throw<InvalidOperationException>()
               .WithMessage("The collection has been marked as complete with regards to additions.");
        }

           

    }
}
