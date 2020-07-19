using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace task_3._2._1
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private T[] array;

        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                if (IsValidIndex(index))
                {
                    return array[index];
                }

                else
                {
                    throw new ArgumentOutOfRangeException("Попытка получить элемент" + index + 1 + ", когда массив имеет элементы " + Length);
                }
            }

            set
            {
                if (IsValidIndex(index))
                {
                    array[index] = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException("Попытка установить элемент" + index + 1 + ", когда массив имеет элементы " + Length);
                }
            }
        }

        private bool IsValidIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                return false;
            }

            return true;
        }

        private int CalcCapacity(int count)
        {
            int i = 8;

            while (i < count)
            {
                i *= 2;
            }

            return i;
        }

        public DynamicArray()
        {
            array = new T[8];
            Capacity = CalcCapacity(8);
        }

        public DynamicArray(int n)
        {
            array = new T[n];
            Capacity = CalcCapacity(n);
        }

        public DynamicArray(IEnumerable<T> inputArr)
        {
            array = new T[inputArr.Count()];

            for (int i = 0; i < inputArr.Count(); i++)
            {
                array[i] = inputArr.ElementAt(i);
            }

            Capacity = CalcCapacity(inputArr.Count());
        }

        public void Add(T item)
        {
            if (Length == Capacity)
            {
                Capacity *= 2;
            }

            T[] _arr = new T[Length + 1];

            for (int i = 0; i < Length; i++)
            {
                _arr[i] = array[i];
            }

            array = _arr;
            array[Length - 1] = item;

        }


        public void AddRange(IEnumerable<T> _arr)
        {
            if (Length + _arr.Count() > Capacity)
            {
                Capacity *= 2;
            }
            T[] _arr2 = new T[Length + _arr.Count()];
            for (int i = 0; i < Length; i++)
            {
                _arr2[i] = array[i];
            }
            for (int i = 0; i < _arr.Count(); i++)
            {
                _arr2[Length + i] = _arr.ElementAt(i);
            }
            array = _arr2;
        }

        public bool RemoveByIndex(int index)
        {
            if (index > Length - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Попытка удалить элемент" + index + ", когда массив имеет элементы " + Length);
            }

            else
            {
                T[] _arr = new T[Length - 1];
                for (int i = 0; i < _arr.Count(); i++)
                {
                    if (i < index)
                    {
                        _arr[i] = array[i];
                    }

                    else
                    {
                        _arr[i] = array[i + 1];
                    }
                }
                array = _arr;
                return true;
            }
        }

        public bool Insert(T item, int index)
        {
            if (index > Length - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Попытка вставить элемент" + index + ", когда массив имеет элементы " + Length);
            }

            else
            {
                T[] _arr = new T[Length + 1];
                for (int i = 0; i < _arr.Count(); i++)
                {
                    if (i < index)
                    {
                        _arr[i] = array[i];
                    }

                    else if (i == index)
                    {
                        _arr[i] = item;
                    }

                    else
                    {
                        _arr[i] = array[i - 1];
                    }
                }

                array = _arr;
                return true;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }
    }
}
