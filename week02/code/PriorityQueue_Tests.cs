using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue elements with varying priorities and dequeue them.
    // Expected Result: Elements are dequeued in descending order of priority, 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1); // Priority 1
        priorityQueue.Enqueue("Task2", 3); // Priority 3
        priorityQueue.Enqueue("Task3", 2); // Priority 2
        // Dequeue in order of priority
        Assert.AreEqual("Task2", priorityQueue.Dequeue()); // Priority 3
        Assert.AreEqual("Task3", priorityQueue.Dequeue()); // Priority 2
        Assert.AreEqual("Task1", priorityQueue.Dequeue()); // Priority 1
    }

    [TestMethod]
    // Scenario: Enqueue elements with identical priorities and dequeue them.
    // Expected Result: Elements are dequeued in the order they were enqueued (FIFO) since their priorities are the same.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
                priorityQueue.Enqueue("Task1", 2); // Priority 2
        priorityQueue.Enqueue("Task2", 2); // Priority 2
        priorityQueue.Enqueue("Task3", 2); // Priority 2
        // Dequeue should respect FIFO for same priority
        Assert.AreEqual("Task1", priorityQueue.Dequeue());
        Assert.AreEqual("Task2", priorityQueue.Dequeue());
        Assert.AreEqual("Task3", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: Throws an InvalidOperationException with the message "Cannot dequeue from an empty queue."
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("An exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("Cannot dequeue from an empty queue.", e.Message);
        }
        catch
        {
            Assert.Fail("An unexpected exception type was thrown.");
        }
    }
}