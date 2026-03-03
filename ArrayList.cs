namespace DefaultNamespace;

public class ArrayList
{
    private int[] _array = new int[10];
    private  int _count =0;

    public void Add(int value)
    {
        _array[_count] = value;
        _count += 1;
        if (_count == _array.Length)
        {
            var extendedArray = new int[_array.Length * 2];
            for (var i, i < _array.Length, i++)
            {
                extendedArray[i] = _array[i];
            }
            _array = extendedArray;
        }
    }

    public void Remove(int numer)
    {
        for(int i = 0, i < _count, i++) 
        {
            if (_array[i] == numer)
            {
                for (int j = i; j < _count -1; j++) 
                 {
                    _array[j] = _array[j+1]
                }

                _count _ = 1;
                return;
            } 
        }
    }

    public int Count()
    {
        return _count;
    }
}