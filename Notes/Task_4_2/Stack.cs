using System;

public class Stack<T> : IStack<T>
{
    private T[] items; // элементы стека
    private int count;  // количество элементов
    const int n = 25;   // количество элементов в массиве по умолчанию

    public int Count
    {
        get => count;
    }

    public Stack()
    {
        items = new T[n];
    }

    // пуст ли стек
    public bool IsEmpty()
    {
        return count == 0;
    }
    // добвление элемента
    public void Push(T item)
    {
        // если стек заполнен, выбрасываем исключение
        if (count == items.Length)
            throw new InvalidOperationException("Переполнение стека");
        items[count++] = item;
    }
    // извлечение элемента
    public T Pop()
    {
        // если стек пуст, выбрасываем исключение
        if (IsEmpty())
            throw new InvalidOperationException("Стек пуст");
        T item = items[--count];
        items[count] = default(T); // сбрасываем ссылку
        return item;
    }

    public override string ToString()
    {
        var k = "";
        for (int i = 0; i < count; i++)
        {
            k += $"{items[i]}  ";
        }
        return k;
    }
}
