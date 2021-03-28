using System;


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
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }
        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = new int[value.Length];
            _array = (int[])value.Clone();
        }

        public int this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }

            _array[Length] = value;
            Length++;
        }
        public void AddToTheBeginning(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            int[] tmpArray = new int[_array.Length];
            tmpArray[0] = value;
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i + 1] = _array[i];
            }
            _array = tmpArray;
            Length++;
        }

        public void RemoveFromTheEnd(int number = 1)
        {
            if (number < 0)
            {
                throw new ArgumentException();
            }

            if (number >= Length)
            {
                Length = 0;
                DownSize();
            }
            else
            {
                Length -= number;
                if (Length <= (int)(_array.Length * 0.67 + 1))
                {
                    DownSize();
                }
            }
        }

        public void RemoveFromTheBeginning(int number = 1)
        {
            if (number < 0)
            {
                throw new ArgumentException();
            }
            if (number >= Length)
            {
                Length = 0;
                DownSize();
            }
            else
            {
                for (int i = number; i < Length; i++)
                {
                    _array[i - number] = _array[i];
                }
                Length -= number;
                if (Length <= (int)(_array.Length * 0.67 + 1))
                {
                    DownSize();
                }
            }

        }

        public void RemoveByIndex(int index, int number = 1)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (number < 0)
            {
                throw new ArgumentException();
            }
            if (number >= Length - index)
            {
                Length -= Length - index;
            }
            else
            {
                for (int i = index; i + number < Length; i++)
                {
                    _array[i] = _array[i + number];
                }
                Length -= number;

            }
            if (Length <= (int)(_array.Length * 0.67 + 1))
            {
                DownSize();
            }

        }

        public int GetIndexByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            throw new Exception("Лист не содержит переданное значение");
        }

        public void ReversList()
        {
            int j = Length - 1;
            int tmp;
            for (int i = 0; i <= ((Length) / 2) - 1; i++)
            {
                tmp = _array[j];
                _array[j] = _array[i];
                _array[i] = tmp;
                j--;
            }
        }

        public int GetMaxElement()
        {
            if (Length == 0)
            {
                throw new NullReferenceException();
            }
            int maxElement;
            maxElement = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > maxElement)
                {
                    maxElement = _array[i];
                }
            }
            return maxElement;
        }

        public int GetMinElement()
        {
            if (Length == 0)
            {
                throw new NullReferenceException();
            }
            int minElement;
            minElement = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < minElement)
                {
                    minElement = _array[i];
                }
            }
            return minElement;
        }

        public int GetIndexOfMaxElement()
        {
            if (Length == 0)
            {
                throw new NullReferenceException();
            }
            int indexOfMaxElement;
            indexOfMaxElement = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > _array[indexOfMaxElement])
                {
                    indexOfMaxElement = i;
                }
            }
            return indexOfMaxElement;
        }

        public int GetIndexOfMinElement()
        {
            if (Length == 0)
            {
                throw new NullReferenceException();
            }
            int indexOfMinElement;
            indexOfMinElement = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < _array[indexOfMinElement])
                {
                    indexOfMinElement = i;
                }
            }
            return indexOfMinElement;
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            if (this.Length != arrayList.Length)
            {
                return false;
            }
            for (int i = 0; i < this.Length; i++)
            {
                if (this._array[i] != arrayList._array[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string arrayToString = "";
            for (int i = 0; i < Length; i++)
            {
                arrayToString += $"{_array[i]} ";
            }
            return arrayToString;
        }

        public void AscendingSort()
        {
            int tmp;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[j] < _array[i])
                    {
                        tmp = _array[j];
                        _array[j] = _array[i];
                        _array[i] = tmp;
                    }
                }
            }
        }

        public void DescendingSort()
        {
            int tmp;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[j] > _array[i])
                    {
                        tmp = _array[j];
                        _array[j] = _array[i];
                        _array[i] = tmp;
                    }
                }
            }
        }

        public int RemoveFirstByValue(int value)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    RemoveByIndex(i);
                    index = i;
                    break;
                }
            }
            return index;
        }

        public int RemoveAllByValue(int value)
        {
            int counter = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    RemoveByIndex(i);
                    i--;
                    counter++;
                }
            }
            return counter;
        }

        public void AddListToTheEnd(ArrayList list)
        {
            Length += list.Length;
            if (Length >= _array.Length)
            {
                UpSize();
            }
            int j = 0;
            for (int i = Length - list.Length; i < Length; i++)
            {
                _array[i] = list[j];
                j++;
            }
        }

        public void AddListByIndex(ArrayList list, int index = 0)
        {
            
            Length += list.Length;
            if (Length >= _array.Length)
            {
                UpSize();
            }
            ShiftRight(index, list.Length);
            int j = 0;

            for (int i = index; i < index + list.Length; i++)
            {
                _array[i] = list[j];
                j++;
            }
        }



        private void ShiftRight(int startIndex, int steps)
        {
            if (startIndex >= Length || startIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (steps < 0)
            {
                throw new ArgumentException();
            }

            for (int i = Length - 1; i > steps - 1; i--)
            {
                _array[i] = _array[i - steps];
            }
        }

        //private void ShiftLeft(int startIndex, int steps)
        //{
        //    if (startIndex >= Length || startIndex < 0)
        //    {
        //        throw new IndexOutOfRangeException();
        //    }

        //    if (steps < 0)
        //    {
        //        throw new ArgumentException();
        //    }

        //    for (int i = startIndex; i < Length - steps; i++)
        //    {
        //        _array[i] = _array[i + steps];
        //    }
        //}

        private void UpSize()
        {
            int newLength = (int)(Length * 1.33 + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        private void DownSize()
        {
            int newLength = (int)(_array.Length * 0.67 + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }


    }
}
