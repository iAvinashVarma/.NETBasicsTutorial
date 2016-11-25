using System;
using System.Collections;
using System.Collections.Generic;

namespace Day14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Generic Collections

            GenericListCollection gList = new GenericListCollection();
            gList.DoList();

            GenericDictionaryCollection gdDic = new GenericDictionaryCollection();
            gdDic.DoDictionary();

            #endregion Generic Collections

            #region Non Generic Collections

            NonGenericHashtableCollection ngHashtable = new NonGenericHashtableCollection();
            ngHashtable.DoHashtable();

            #endregion Non Generic Collections
        }
    }

    internal class GenericListCollection
    {
        internal void DoList()
        {
            List<string> listValues = new List<string>();
            listValues.Add("One");
            listValues.Add("Two");

            List<string> listAnother = new List<string> { "One", "Two", "Three", "Four" };
            listAnother.Remove("Three");
        }
    }

    internal class GenericDictionaryCollection
    {
        internal void DoDictionary()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>{
               {"TS", "Hyderabad"},
               {"AP", "Amaravathi"},
               {"TN", "Chennai"}
           };

            string karCity;
            if (!dic.TryGetValue("Bangalore", out karCity))
            {
                dic.Add("KN", "Bangalore");
            }

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine(string.Format("Key : {0} | Value : {1}.", item.Key, item.Value));
            }

            Dictionary<string, List<string>> dicList = new Dictionary<string, List<string>>{
                {
                    "India",
                    new List<string>{"AP", "TS", "TN", "MP"}
                },
                {
                    "USA",
                    new List<string>{"NY", "LA", "VA", "LV"}
                }
            };

            foreach (KeyValuePair<string, List<string>> item in dicList)
            {
                Console.WriteLine(string.Format("{1}Country is {0}{1}", item.Key, Environment.NewLine));
                foreach (string states in item.Value)
                {
                    Console.WriteLine(states);
                }
            }
        }
    }

    internal class NonGenericHashtableCollection
    {
        internal void DoHashtable()
        {
            Hashtable hTable = new Hashtable();
            hTable.Add("TS", "Hyderabad");
            hTable.Add("AP", "Amaravathi");
            hTable.Add("TN", "Chennai");

            if (hTable.ContainsValue("Chennai"))
                Console.WriteLine("Already available");
            else
                hTable.Add("TN", "Chennai");

            ICollection keyCollection = hTable.Keys;
            ICollection valueCollection = hTable.Values;

            foreach (var item in keyCollection)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (var item in valueCollection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}