using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set; }
                      
        private int[] _array;

        public ArrayList()
        {
            Length = 0;

            _array = new int[10];
        }

        public void AddLast(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            
            _array[Length] = value;
            Length++;
        }

        public void AddFirst(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }

            
            for (int i = Length; i > 0 ; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[0] = value;
            Length++;
        }

        public void AddValueByIndex(int index, int value)
        {
            if (index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (Length == _array.Length)
            {
                UpSize();
            }

            for(int i = Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = value;
            Length++;
        }

        public void RemoveLast()
        {
            Length--;
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
        }

        public void RemoveFirst()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            Length--;
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
        }

        public void RemoveValueByIndex(int index)
        {
            for (int i = index; i < Length - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            Length--;
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
        }

        public int GetValueByIndex(int index)
        {
            if (index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            
            return _array[index];
        }

        public int FirstIndexByValue (int value)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }


        public void ChangeValueByIndex (int index, int value)
        {
            if (index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            _array[index] = value;
        }

        public void Reverse()
        {
            int tmpArrayNumber;
            for (int i = 0; i < Length / 2; i++)
            {
                tmpArrayNumber = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmpArrayNumber;
            }
        }

        public int MinValue()
        {
            int minValue = _array[0];
            for (int i = 0; i < Length; i ++)
            {
                if (minValue < _array[i])
                {
                    minValue = _array[i];
                }
            }
            return minValue;
        }

        public int MaxValue()
        {
            int maxValue = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (maxValue > _array[i])
                {
                    maxValue = _array[i];
                }
            }
            return maxValue;
        }

        public int IndexOfMinValue()
        {
            int minValue = _array[0];
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (minValue < _array[i])
                {
                    minValue = _array[i];
                    index = i;
                }
            }
            return index;
        }

        public int IndexOfMaxValue()
        {
            int maxValue = _array[0];
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (maxValue > _array[i])
                {
                    maxValue = _array[i];
                    index = i;
                }
            }
            return index;
        }










        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.33d + 1);

            int[] tmpArray = new int[newLength];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }

            _array = tmpArray;
        }

        private void DownSize()
        {
            int newLength = (int)(_array.Length * 0.67d + 1);

            int[] tmpArray = new int[newLength];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }

            _array = tmpArray;
        }
    }
}
