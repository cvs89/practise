using System;
using System.Collections.Generic;

namespace stack
{
    class Stack
    {
        private List<object> data = new List<object>();

        public void Push(object obj)
        {
            data.Add(obj);
        }

        public object Pop()
        {
            if(data.Count == 0)
            {
                throw new InvalidOperationException("You are pulling from empty list");
            }
            var element = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return element;
        }

        public void Clear()
        {
            if (data.Count == 0)
            {
                throw new InvalidOperationException("You are clearing an empty list");
            }
            data.Clear();
        }

    }
}
