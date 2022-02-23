using DesignPatterns.CreationalPatterns.SingletonPattern;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.CreationalPatterns.Tests.SingletonPattern
{
    public class SingletonClassTests
    {
        [Fact]
        public void CreateSingletonObject_OneThread_CreatesObject()
        {
            // Arrange
            SingletonClass singletonPattern = SingletonClass.GetInstance();
            int expectedNum = 1;

            // Act
            singletonPattern.anInteger++;

            // Assert
            Assert.Equal(expectedNum, singletonPattern.anInteger);
        }

        [Fact]
        public void CreateSingletonObject_MultipleThreads_CreatesObject()
        {
            // Arrange
            SingletonClass singletonPattern = SingletonClass.GetInstance();
            int numOfTasks = 1000;
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < numOfTasks; i++)
            {
                Task task = new Task(() => singletonPattern.anInteger++);
                tasks.Add(task);
            }

            // Act
            tasks.ForEach(task => task.Start());
            Task.WaitAll(tasks.ToArray());

            // Assert
            Assert.Equal(numOfTasks, singletonPattern.anInteger);
        }
    }
}