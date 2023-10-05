using System;
using System.Collections;
using System.Collections.Generic;




MyHashMap myHashMap = new MyHashMap();
myHashMap.Put(1, 1);
myHashMap.Put(15, 1);
Console.WriteLine(myHashMap.Get(1));
Console.WriteLine(myHashMap.Get(15));

public class MyHashMap
{
    private int?[] Values {  get; set; }

    const int capacity = 1000000;
    public bool ContainsKey(int key) => Values[KeyHashCode(key)] != null; 
    
    public int KeyHashCode(int key)
    {
        return Math.Abs( key.GetHashCode()) % capacity;
    }
    public MyHashMap()
    {
        Values = new int?[capacity];
    }

    public void Put(int key, int value) => Values[KeyHashCode(key)] = value;

    public int Get(int key) => ContainsKey(key) ? (int)Values[KeyHashCode(key)] : -1;

    public void Remove(int key) => Values[KeyHashCode(key)] = null;

}