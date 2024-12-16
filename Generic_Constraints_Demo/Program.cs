using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Generic_Constraints_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataStore<string> store = new DataStore<string>();
            // DataStore<MyClass> store = new DataStore<MyClass>();
            // DataStore<IMyInterface> store = new DataStore<IMyInterface>();
            // DataStore<IEnumerable> store = new DataStore<IMyInterface>();
            // DataStore<ArrayList> store = new DataStore<ArrayList>();
            // DataStore<int> store = new DataStore<int>();


            //DataStore<MyClass> store = new DataStore<MyClass>(); // valid
            //DataStore<ArrayList> store = new DataStore<ArrayList>(); // valid
            //DataStore<string> store = new DataStore<string>(); // compile-time error 
            //DataStore<int> store = new DataStore<int>(); // compile-time error 
            //DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // compile-time error



            //DataStore<ArrayList> store = new DataStore<ArrayList>(); // valid
            //DataStore<List> store = new DataStore<List>(); // valid

        }
    }



    class DataStore<T> where T : IEnumerable
    {
        public T Data { get; set; }
    }

    //class DataStore<T> where T : class, new()
    //{
    //    public T Data { get; set; }
    //}

    //class MyClass
    //{
    //}

    //class DataStore<T> where T : struct
    //{
    //    public T Data { get; set; }
    //}

    //class DataStore<T> where T : class
    //{
    //    public T? Data { get; set; }
    //}
}
