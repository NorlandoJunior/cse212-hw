using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
// Scenario: Add three items with different priorities.
// Expected Result: The item with the highest priority should be removed first.
// Defect(s) Found: The queue did not properly identify the highest priority item.
public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("Bob", 1);
    priorityQueue.Enqueue("Tim", 5);
    priorityQueue.Enqueue("Sue", 3);

    var result = priorityQueue.Dequeue();

    Assert.AreEqual("Tim", result);
}

    [TestMethod]
// Scenario: Add multiple items with the same priority.
// Expected Result: Items with the same priority should be dequeued in the order they were added.
// Defect(s) Found: The queue returned the most recently added item instead of preserving FIFO order.
public void TestPriorityQueue_2()
{
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("Bob", 5);
    priorityQueue.Enqueue("Tim", 5);
    priorityQueue.Enqueue("Sue", 5);

    var result = priorityQueue.Dequeue();

    Assert.AreEqual("Bob", result);
}
    // Add more test cases as needed below.
}