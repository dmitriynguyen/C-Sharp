interface IStack<T>
{
    void Push(T obj);
    T Pop();
    bool IsEmpty();
}
