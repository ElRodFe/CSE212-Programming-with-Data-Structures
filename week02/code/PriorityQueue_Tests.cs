using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Queue is Empty
    // Expected Result: Error excetion is thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
    }

    [TestMethod]
    // Scenario: More than one item with Highest priority
    // Expected Result: Among them, item with order priority goes first
    // Defect(s) Found: Deqeueue was not cheking all queue items, nor looking for first higher priority number correctly, nor removing items from queue
    public void TestPriorityQueue_TwoHigherPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Sister", 4);
        priorityQueue.Enqueue("Brother 1", 10);
        priorityQueue.Enqueue("Dad", 2);
        priorityQueue.Enqueue("Brother 2", 10);
        priorityQueue.Enqueue("Mom", 1);

        string result = priorityQueue.Dequeue();

        Assert.AreEqual("Brother 1", result, "Expected the first high-priority item to be dequeued first.");
    }

    // Add more test cases as needed below.
}