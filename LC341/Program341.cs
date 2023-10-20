// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



  // This is the interface that allows for creating nested lists.
  // You should not implement it, or speculate about its implementation
public interface NestedInteger
{

    // @return true if this NestedInteger holds a single integer, rather than a nested list.
    bool IsInteger();

    // @return the single integer that this NestedInteger holds, if it holds a single integer
    // Return null if this NestedInteger holds a nested list
    int GetInteger();

    // @return the nested list that this NestedInteger holds, if it holds a nested list
    // Return null if this NestedInteger holds a single integer
    IList<NestedInteger> GetList();
  }

public class NestedIterator
{
    public List<int> Res { get; private set; }
    
    public int LastIndex { get; private set; }
    public NestedIterator(IList<NestedInteger> nestedList)
    {
        Res = InitializationList(nestedList);
        LastIndex = 0;
    }

    private static List<int> InitializationList(IList<NestedInteger> nestedList) 
    {
        List<int> res = new List<int>();
        foreach (var item in nestedList)
        {
            if (item.IsInteger())
            {
                res.Add(item.GetInteger()); // если int, просто добавляем его в list
            }
            else
            { // если list, рекурсивно расскрываем его пока не будет int, доавляем пачку -- IEnumerable 
                res.AddRange(InitializationList(item.GetList())); 
            }
        }
        return res;
    }

    public bool HasNext() => (LastIndex < Res.Count);

    public int Next() => Res[LastIndex++];
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */