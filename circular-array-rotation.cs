using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'circularArrayRotation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
     */

    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
    {
        int n = a.Count;
        k = k % n;

        List<int> rotated = new List<int>(new int[n]);

        
        for (int i = 0; i < n; i++)
        {
            rotated[(i + k) % n] = a[i];
        }

        
        List<int> result = new List<int>();
        
        foreach (int index in queries)
        {
            result.Add(rotated[index]);
        }

        return result;
    }

}

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    
    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    // Head node of the list
    private Node<T> head;

    // Constructor to initialize an empty linked list
    public LinkedList()
    {
        head = null;
    }

    // Adds a node to the beginning of the list
    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.Next = head; // Set the new node's next to the current head
        head = newNode;      // Update the head to be the new node
    }

    // Adds a node to the end of the list
    public void AddLast(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (head == null)
        {
            // If the list is empty, set the new node as the head
            head = newNode;
            return;
        }

        // Traverse to the end of the list
        Node<T> current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        // Set the last node's next to the new node
        current.Next = newNode;
    }

    // Prints all nodes in the list
    public void PrintList()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data); // Print the data of the current node
            current = current.Next;         // Move to the next node
        }
    }

    // Removes the first occurrence of the specified data from the list
    public void Remove(T data)
    {
        if (head == null) return; // If the list is empty, do nothing

        // If the head node contains the data, update the head
        if (head.Data.Equals(data))
        {
            head = head.Next;
            return;
        }

        // Traverse the list to find the node to remove
        Node<T> current = head;
        while (current.Next != null && !current.Next.Data.Equals(data))
        {
            current = current.Next;
        }

        // Remove the node by skipping it in the list
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // Finds the first occurrence of the specified data
    public Node<T> Find(T data)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return current;
            }
            current = current.Next;
        }
        return null; // Return null if the data is not found
    }

    // Counts the number of nodes in the list
    public int Count()
    {
        int count = 0;
        Node<T> current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // Clears the list by removing all nodes
    public void Clear()
    {
        head = null; // Simply set the head to null
    }
    
    public static List<int> RotateRightOnce(List<int> a)
    {
        if (a.Count == 0) return a;

        int last = a[a.Count - 1];
        a.RemoveAt(a.Count - 1);
        a.Insert(0, last);

        return a;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int q = Convert.ToInt32(firstMultipleInput[2]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> queries = new List<int>();

        for (int i = 0; i < q; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
            queries.Add(queriesItem);
        }

        List<int> result = Result.circularArrayRotation(a, k, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
