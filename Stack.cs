namespace DefaultNamespace;

public class Stack
{
    private int size = 50;

    private string[] _array new string[size] ;
    private int _сount;

    public void Push(string value)
    {
        if (_count == _array.Length )
        {
            throw new Exception("Stack is overflow")
        }
        _array[_count] = value;
        _count++
    }

    public string Pop()
    {
        if (_count == 0)
        {
            throw new Exception("Stack is empty")
        }

        var value = _array[_count]
        _count--
        return value;
    }
}