using System;
using System.Collections;
using System.Collections.Generic;


MyStack obj = new MyStack();
obj.Push(5);
obj.Push(6);
int param_2 = obj.Pop();
int param_3 = obj.Top();
bool param_4 = obj.Empty();

public class MyStack
{
    public Queue<int> data = new Queue<int>();
    public MyStack()
    {

    }

    public void Push(int x)
    {
        var newData = new Queue<int>();
        newData.Enqueue(x);
        foreach (var i in data)
        {
            newData.Enqueue(i);
        }
        data = newData;
    }

    public int Pop() => data.Dequeue();


    public int Top() => data.Peek();


    public bool Empty() => data.Count == 0;

}