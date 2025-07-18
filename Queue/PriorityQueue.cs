﻿namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public class PriorityQueue {
    private List<Node> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue irregardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority) {
        var newNode = new Node(value, priority);
        bool posFound = false;
        var index = 0;

        // if queue is empty, add node
        if (_queue.Count == 0)
        {
            _queue.Add(newNode);
        }
        // if queue is not empty check each value
        else
        {
            while (!posFound)
            {
                if (priority >= _queue.Count)
                {
                    if ((index) == _queue.Count)
                    {
                        _queue.Add(newNode);
                        posFound = true;
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    _queue.Insert(index, newNode);
                    posFound = true;
                }
            }
            
        }

    }

    public String Dequeue() {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count - 1; index++) {
            if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        return value;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class Node {
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal Node(string value, int priority) {
        Value = value;
        Priority = priority;
    }

    public override string ToString() {
        return $"{Value} (Pri:{Priority})";
    }
}