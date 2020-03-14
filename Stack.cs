using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Stack<T>
    {
        private T[] stackArray;
        private int maximumLength;

        public int Size { get; private set; }

        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
    }
}
