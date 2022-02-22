using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.CreationalPatterns.Tests
{
    public class SingletonPatternTests
    {
        [Fact]
        public void Edit_OneThread_CreatesObject()
        {
            // Arrange
            SingletonPattern singletonPattern = SingletonPattern.GetInstance();
            int expectedNum = 1;

            // Act
            singletonPattern.anInteger++;

            // Assert
            Assert.Equal(expectedNum,singletonPattern.anInteger);
        }

        [Fact]
        public void CreateSingletonObject_MultipleThreads_CreatesObject()
        {
            // Arrange
            SingletonPattern singletonPattern = SingletonPattern.GetInstance();
            int numOfTasks = 100;
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < numOfTasks; i++)
            {
                Task task = new Task(() => singletonPattern.anInteger++);
                tasks.Add(task);    
            }

            // Act
            tasks.ForEach(task =>task.Start());
            Task.WaitAll(tasks.ToArray());

            // Assert
            Assert.Equal(numOfTasks,singletonPattern.anInteger );
        }
    }
}