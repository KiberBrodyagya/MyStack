using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyStack
    {
        public int length;
        //private readonly int maxLength;
        public List<char> elem;
        public MyStack(int Length)
        {
            length = Length;
            elem = new List<char>(Length);            
        }
        public void Clear() 
        {
            if(length > 0)
            {
                elem.Clear();
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }
        public bool isEmpty()
        {
            if (elem.Count != 0) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public char Pop() 
        {
            if (length > 0)
            {
                var item = elem.LastOrDefault();
                elem.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }
        public void Push(char Element) 
        {
            elem.Add(Element);
        }
        public char Top() 
        {
            if (length > 0)
            { 
                var item = elem.LastOrDefault();
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пустой");
            }
        }
    }
}
