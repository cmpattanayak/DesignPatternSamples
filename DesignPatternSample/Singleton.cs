using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample
{
    public sealed class Singleton
    {
        private static int counter = 0;

        //By defauly Lazy<T> objects are thread safe
        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        private static readonly object obj = new object();

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter);
        }

        public static Singleton GetInstance
        {
            get
            {
                //if (instance == null)
                //{
                //    lock (obj)
                //    {
                //        if (instance == null)
                //            instance = new Singleton();
                //    }
                //}
                //return instance;

                return instance.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
