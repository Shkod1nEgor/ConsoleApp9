using System;

namespace ConsoleApp1
{
    class Instantiator<T>
    {
        private static void Main(string[] args)
         private T instance;

        public T Instance { get => instance; set => instance = value; }

        public Instantiator()
         {
                Instance = default(T);
         }       
    }   
}
