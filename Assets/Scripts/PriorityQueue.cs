using System;
using System.Collections.Generic;
using System.Linq;

class PriorityQueue<P, V>
{
    private readonly SortedDictionary<P, Queue<V>> queueMap = new SortedDictionary<P, Queue<V>>();

    public void Enqueue(P priority, V value)
    {
        Queue<V> q;
        if (!queueMap.TryGetValue(priority, out q))
        {
            q = new Queue<V>();
            queueMap.Add(priority, q);
        }
        q.Enqueue(value);
    }

    public V Dequeue()
    {
        var pair = queueMap.First();
        var v = pair.Value.Dequeue();
        if (pair.Value.Count == 0) 
            queueMap.Remove(pair.Key);
        return v;
    }

    public bool IsEmpty
    {
        get { return !queueMap.Any(); }
    }
}