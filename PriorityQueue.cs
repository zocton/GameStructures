namespace GameStructures;

public class PriorityQueue<T>
{
    public override bool Equals(object? obj) => obj is PriorityQueue<T> queue && EqualityComparer<List<PriorityQueue<T>.PQItem>>.Default.Equals(_list, queue._list) && EqualityComparer<Queue<PriorityQueue<T>.PQItem>>.Default.Equals(_queue, queue._queue) && Count == queue.Count;
    public override int GetHashCode() => HashCode.Combine(_list, _queue, Count);

    public class PriorityQueueException : Exception
    {
        public override string Message => base.Message + $"{Environment.NewLine}Attempting to dequeue an empty PriorityQueue.";
    }

    internal struct PQItem
    {
        internal T? Value { get; } = default;
        internal int Priority { get; } = -1;

        internal PQItem(T value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }

    private readonly List<PQItem> _list = new();
    private Queue<PQItem> _queue = new();

    public int Count { get; private set; } = 0;

    public void Enqueue(T element, int priority)
    {
        Count++;

        _list.Add(new(element, priority));
        _queue = new Queue<PQItem>(_list.OrderByDescending(value => value.Priority));
    }

    public T? Dequeue()
    {
        if (Count == 0)
        {
            throw new PriorityQueueException();
        }

        Count--;

        var dequeued = _queue.Dequeue();
        _list.Remove(dequeued);

        return dequeued.Value!;
    }

    public T? Peek()
    {
        return _queue.Count > 0 ? _queue.Peek().Value : default;
    }
}
