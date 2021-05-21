using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStack
{
    public class MyStack<T>
    {
        private int _size;
        private LinkedList<T> _sList;

        public MyStack(int size)
        {
            _size = size;
            _sList = new LinkedList<T>();
        }

        #region Stack Class

        /// <summary>
        /// Add element into the stack.
        /// </summary>
        /// <param name="vale"></param>
        public void Push(T vale)
        {
            if (_sList.Count == _size) { _sList.RemoveLast(); }
            _sList.AddFirst(vale);
        }

        /// <summary>
        /// Removes and returns the object at the top of the System.Collections.Stack.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            try
            {
                if (_sList.Count > 0)
                {
                    _sList.RemoveFirst();
                    return _sList.First.Value; ;
                }
                else
                {
                    throw new InvalidOperationException("Stack is empty.");
                }
            }
            catch
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        /// <summary>
        /// Returns the object at the top of the System.Collections.Stack without removing
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (_sList.Count > 0)
            {
                return _sList.First.Value;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        /// <summary>
        /// Return the total element of stack.
        /// </summary>
        public int Count { get { return this._sList.Count; } }

        /// <summary>
        /// Check if element is to of stack.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsTop(T value)
        {
            if (_sList.Count > 0)
            {
                return Peek().Equals(value);
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        /// <summary>
        /// Search element if is member of stack.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            if (_sList.Count > 0)
            {
                bool isMatch = _sList.Contains(value);
                return _sList.Contains(value);
            }
            else
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        /// <summary>
        /// Clear stack.
        /// </summary>
        public void Clear()
        {
            this._sList.Clear();
        }

        #endregion

        public IEnumerator GetEnumerator()
        {
            return _sList.GetEnumerator();
        }

    }
}
