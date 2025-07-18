namespace prove_04;

/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue {
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person) {
        _queue.Insert(0, person);
    }

    public Person Dequeue()
    {
        var endOfQueue = _queue.Count - 1;
        var person = _queue[endOfQueue];
        _queue.RemoveAt(endOfQueue);
        return person;
    }

    public bool IsEmpty() {
        return Length == 0;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
    
}
