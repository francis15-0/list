using System.ComponentModel;

public interface IList<T> : IContainer {
    public void Add(T item);
    public void Remove(T item);
    public bool Contains(T item);
    public void RemoveAt(int p);
    public void Insert(T item, int p);
    public void DoubleCapacity();
}

public interface IContainer<T> {
    public void MakeEmpty();
    public bool Empty();
    public int Size();
    public void print();
}

  class List<T> : IList<T> {
    private T[] A;
    private int Count;
    private int capacity;
    public List() {
        capacity = 8;
        A = new T[capacity];
        
    }

    public void Add(T item) { }
    public void Remove(T item) { }
    public bool Contains(T item) {
        
    }
    public void DoubleCapacity() {
        T[] oldA = A;
        capacity = capacity * 2;
        A = new T[capacity];
        for (int i = 0; i < Count; i++) {
            A[i] = oldA[i];
        }
    }
    public void RemoveAt(int p) { }

    public void MakeEmpty() { }
    public bool Empty() { 
        return Count == 0;
    }
    public int Size() {
        return Count;
    }
    public void print() {
        for (int i = 0; i < Count; i++)
        {
            Console.WriteLine(A[i]);
        }
    }

}
    




public static class structure {
    public static void Main() {
    

    }
}