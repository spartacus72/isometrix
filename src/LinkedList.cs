namespace IsometrixApp;

public class LinkedList<T>
{
    public Node<T>? head;
    private int count;

    public LinkedList()
    {
        head = null;
        count = 0;
    }

    public bool IsEmpty => head == null;

    public int Count => count;

    // Insert a node at any position (0-based indexing)
    public void Insert(int index, T data)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative.");
        }

        if (index == 0)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node<T>? current = head;
            int currentIndex = 0;

            while (current != null && currentIndex < index - 1)
            {
                current = current.Next;
                currentIndex++;
            }

            if (current == null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of bounds.");
            }

            Node<T> newNode = new Node<T>(data);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        count++;
    }

    // Delete a node at any position (0-based indexing)
    public void Delete(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index out of bounds.");
        }

        if (index == 0)
        {
            head = head?.Next;
        }
        else
        {
            Node<T>? current = head;
            int currentIndex = 0;

            while (current != null && currentIndex < index - 1)
            {
                current = current.Next;
                currentIndex++;
            }

            if (current == null || current.Next == null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of bounds.");
            }

            current.Next = current.Next.Next;
        }

        count--;
    }

    // Print the string representation of each node in the list
    public void PrintList()
    {
        Node<T>? current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current?.Next;
        }
        Console.WriteLine("null");
    }
}
