using System.Collections.Concurrent;

namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        //var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: enqueue the highest priority to the front of the queue
        // Expected Result: eggs, steak, milk, butter, bread
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("milk", 2);
        priorityQueue.Enqueue("eggs", 1);
        priorityQueue.Enqueue("bread", 4);
        priorityQueue.Enqueue("steak", 1);
        priorityQueue.Enqueue("butter", 3);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: the priority is not taken into consideration when added to queue

        Console.WriteLine("=================");

        // Test 2
        // Scenario: dequeue function will remove the highest priority item and return its value
        // Expected Result: eggs (Pri:1)
        Console.WriteLine("Test 2");
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: Does not find the index of the highest item, just takes the first item.

        Console.WriteLine("=================");

        // Test 3
        // Scenario:  If the queue is empty, then an error message will be displayed
        // Expected Result: "The queue is empty"
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();

        // Defect(s) Found: None!

    }
}