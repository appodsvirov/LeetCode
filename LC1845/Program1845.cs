// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class SeatManager
{
    /// <summary> Стек непрерывной последовательности. Без удаления "не top элементов" </summary>
    private int topStack; 
    /// <summary>Соритрованная куча удаленных "не top элементов"</summary>
    private SortedSet<int> heap;

    public SeatManager(int n)
    {   
        topStack = 0;
        heap = new SortedSet<int>();
    }

    public int Reserve()
    {
        if (heap.Count == 0) // heap пуст => min элемент = top, т.е. ранее не удалялись "не top элементы"
        {
            return ++topStack;
        }
        else // heap не пуст, значит искомое место находится в heap.Min
        {
            int min = heap.Min();
            heap.Remove(heap.Min);
            return min;
        }
    }

    public void Unreserve(int seatNumber)
    {
        if (seatNumber == topStack) // seatNumber -- "топ элемент",  просто удаляем верхушку стека
        {
            --topStack;
        }
        else
        {
            heap.Add(seatNumber); // в heap попадает удаленный "не топ элемент"
        }
    }
}