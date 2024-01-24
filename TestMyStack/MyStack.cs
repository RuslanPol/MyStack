using System;

namespace TestMyStack
{
    public class MyStack<T>
    {
        private T[] _array;
        private int _lastElem;

        public MyStack( int lenght)
        {
            this._array = new T[lenght];
            this._lastElem = -1;
        }

        public void Push(T element)
        {
            if (_lastElem == _array.Length - 1)
            {
                throw new InvalidOperationException("Stack is full");
            }

            _array[++_lastElem] = element;
        }

        public T Pop()
        {
            if (_lastElem == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T element = _array[_lastElem];
            _array[_lastElem] = default;
            _lastElem--;
            return element;
        }
    }
}