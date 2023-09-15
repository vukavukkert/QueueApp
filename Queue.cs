using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    internal class Queue
    {
        List<int> newList;
        public int Length;
        private int Count = 0;
        public object Clone() => MemberwiseClone();
        public Queue(int Length)
        {
            newList = new List<int>(Length);
            this.Length = Length;
        }
        public Queue(Queue obj)
        {
            Length = obj.Length;
            newList = obj.newList;
            Count = obj.Count;
        }
        public void Enqueue(int value)
        {
            if (Count < Length)
            {
                newList.Add(value);
                Count++;
            }
            else
            {
                throw new InvalidOperationException("Queue is full");
            }
        }
        public int Dequeue()
        {
            Count--;
            int a = newList[Count];
            newList.RemoveAt(Count);
            return a;
        }
        public int Peek()
        {
            return newList[0];
        }
        public void Clear()
        {
            newList = new List<int>(Length);
            Count = 0;
        }
        public bool Contains(int i)
        {
            if (Count == 0) return false;
            foreach (var item in newList) { if (item == i) return true;}
            return false;
        }
    }
}
