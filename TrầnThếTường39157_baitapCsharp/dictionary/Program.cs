using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderedDictionary myDict = new OrderedDictionary();

            // Adding key and value in myDict
            myDict.Add("key1", "value1");
            myDict.Add("key2", "value2");
            myDict.Add("key3", "value3");
            myDict.Add("key4", "value4");
            myDict.Add("key5", "value5");

            // Displaying the number of element initially
            Console.WriteLine("Number of elements are : "
                                         + myDict.Count);

            // Displaying the elements in myDict
            foreach (DictionaryEntry de in myDict)
                Console.WriteLine(de.Key + " -- " + de.Value);

            // Inserting entry into OrderedDictionary
            // with key and value at the specified index
            myDict.Insert(2, "Geeks", "Noida");

            // Displaying the number of element initially
            Console.WriteLine("Number of elements are : "
                                          + myDict.Count);

            // Displaying the elements in myDict
            foreach (DictionaryEntry de in myDict)
                Console.WriteLine(de.Key + " -- " + de.Value);


        }
    }
}
