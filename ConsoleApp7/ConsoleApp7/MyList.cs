using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ConsoleApp7
{



    public class MyList<B> : IMyList<B>
    {
        private B[] items;
        private int count;

        public MyList()
        {
            items = new B[5];
            count = 0;
        }

        public MyList(int capacity)
        {
            items = new B[capacity];
            count = 0;
        }

        public void AddItem(B item)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count++] = item;
        }

        public B GetItemAt(int index)
        {
            CheckIndex(index);
            return items[index];
        }

        private void Resize()
        {
            var newItem = new B[items.Length * 2];
            for (var i = 0; i < items.Length; i++)
            {
                newItem[i] = items[i];
            }
            items = newItem;
        }

        public void CheckIndex(int index)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }



        public void RemoveItemAt(int index)
        {
            CheckIndex(index);
            for (var i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
            items[count] = default(B);
        }

        public void AddItemsRange(B[] nums)
        {
            foreach (var num in nums)
            {
                AddItem(num);
            }
        }

        public void ReplaceAllItems(int oddElement, B newElement)
        {
            for (var i = 0; i < count; i++)
            {
                if (Object.Equals(items[i], oddElement))
                {
                    items[i] = newElement;
                }
            }
        }

        public int GetItemIndex(B item)
        {
            for (var i = 0; i < count; i++)
            {
                if (object.Equals(items[i], item))
                {
                    return i;
                }
            }
            return -1;
        }



        public bool contains(B item)
        {
            if (GetItemIndex(item) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Clear()
        {
            for (var i = 0; i < items.Length; i++)
            {
                RemoveItemAt(i);
            }
        }

        public B[] ToArray()
        {
            if (items.Count() == count)
            {
                return items;
            }

            var result = new B[items.Length];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = items[i];
            }
            return result;
        }

        public void ReplaceAllItems(B oddElement, B newElement)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            return count;
        }

        public int GetCapacity()
        {
            throw new NotImplementedException();
        }

        public void insert(int index, B item)
        {
            if (index < 0 || index > items.Length)
            {
                throw new IndexOutOfRangeException("index out of range");
            }

            B[] newItems = new B[items.Length + 1];
            for (var i = 0; i < index; i++)
            {
                newItems[i] = items[i];
            }

            newItems[index] = item;
            for (var i = index; i < items.Length; i++)
            {
                newItems[i + 1] = items[i];
            }
            items = newItems;
        }

        public void Reverse()
        {
            int start = 0;
            int end = items.Length - 1;
            for (var i = start; i < end; i++)
            {
                B temp = items[start];
                items[start] = items[end];
                items[end] = temp;

                start++;
                end--;
            }
        }

        public B[] GetRange(int startIndex, int EndIndex)
        {
            if (startIndex < 0 || EndIndex >= items.Length || startIndex > EndIndex)
            {
                throw new IndexOutOfRangeException("out of range");
            }
            int length = EndIndex - startIndex + 1;

            B[] range = new B[length];
            for (var i = 0; i < length; i++)
            {
                range[i] = items[startIndex + 1];
            }
            return range;
        }

        public void Sort()
        {

        }

        public int GetLastIndex(B item)
        {
            for (var i = items.Length - 1; i >= 0; i--)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void InsertAt(int index, B item)
        {
            if (items.Count() == count)
            {
                Resize();
            }
            CheckIndex(index);

            for (var i = count; i >= index; i++)
            {
                items[i + 1] = items[i];
            }
            items[index] = item;
            count++;
        }

        public void SortAsSelected()
        {
            for (var i = 0; i < count; i++)
            {
                // 45 18 99 11 56 24
                // 11 18 99 45 56 24
                var minElement = items[i];
                var minIndex = i;
                for (var j = i + 1; j < count; j++)
                {
                    if (Convert.ToInt32(items[j]) < Convert.ToInt32(minElement))
                    {
                        minElement = items[j];
                        minIndex = j;
                    }
                }

                var temp = items[i];
                items[i] = items[minIndex];
                items[minIndex] = temp;
            }
        }

        public void SortAsBubble()
        {
            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count - i - 1; j++)
                {
                    if (Convert.ToInt32(items[j]) < Convert.ToInt32(items[j + 1]))
                    {
                        var temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }

            //public void InsertAt(int index, B item)
            //{
            //    if (items.Count() == count)
            //    {
            //        Resize();
            //    }
            //    CheckIndex(index);
            //    for (var i = count; i >= index; i--)
            //    {
            //        items[i + 1] = items[i];
            //    }
            //    items[index] = item;
            //    count++;
            //}
        }
    }
}









