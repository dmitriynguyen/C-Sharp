public static class ExtensionMethods
{
    public static Stack<T> Reverse<T>(this Stack<T> stack)
    {
        var revStack = new Stack<T>();
        var k = new T[stack.Count];
        var count = stack.Count;

        for (int i = 0; i < count; i++)
        {
            k[i] = stack.Pop();
            revStack.Push(k[i]);
        }
        for (int i = count - 1; i >= 0; i--)
        {
            stack.Push(k[i]);
        }

        return revStack;
    }
}
