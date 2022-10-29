using System;

namespace first {
    
    class MyStack<T>
    {
        
        private int stack;
        public T[] Items;

        public MyStack()
        {
            stack = -1;
        }

        public void InitStack()
        {
           
        }

        public void ClearStack()
        {
            stack = -1;
        }

        public bool push(T item)
        {
            Items[++stack] = item;
            return true;
        }

        public T pop()
        {
            return Items[stack--];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack=new MyStack<int>();
            stack.push(2);
            
            Console.WriteLine(stack.pop());
        }
    }
}
