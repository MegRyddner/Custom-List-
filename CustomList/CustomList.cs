﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
//Use a private void temporary array (private void T[] tempArray = new T[];
//That reassigns back to the member variable array to keep track of what is added
//Make sure the .Count goes up by 1 each time something is added to the list.
//First AddTestMethod, use items [] = item
//items = tempArray; would be the last thing used in the add method, resizing the Array

{
    public class CustomList<T> : IEnumerator<T>
    {
        public int Capacity;

        T[] items;
        private int count;
        public int Count { get { return count; } }
        public int index;


        public CustomList()
        {
            Capacity = 4;
            items = new T[Capacity];
            count = 0;
        }

        
        
        public void Add(T value)
        {
            if (count == Capacity)
            {
                // make a bigger temp array
                Capacity *= 2;
                T[] tempArray = new T[Capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
            count++;
            items[Count - 1] = value;
        }

        public void Remove(T valueToRemove)

        {
            T[] tempArray = new T[Capacity];
            //tempArray[i] = items[valueToRemove];
            int j = 0;
            for (int i = 0; i < count; i++, j++)
            // check to see if items[i] is equal to valueToRemove
            {
                {
                    if (items[i].Equals(valueToRemove) && count != items.Length)
                    {
                        i++;
                        tempArray[j] = items[i];
                    }
                    else if (count == items.Length)
                    {
                        break;
                    }
                    else
                    {
                        tempArray[j] = items[i];
                    }
                }
            }
            items = new T[count];
            items = tempArray;
            count--;
        }

        //use yield return after foreach loop & public IEnumerator GetEnumerator()
        //convert list to string, using a for loop to create string
        public override string ToString() 
        {
            string name = "M" + "H";
            name += "";

            string result = "";
            for (int i = 0; i < this.Count(); i++) ;
            output = Integer.toString(this.Get(i));




            return result;
            
            //foreach (string value in myList)
            {

            }

            //myList = List + List;
            //yield return;
           


        }

        

        public void Zip(T value)
        {

        }
    }

            

        //{
        //    //{
        //    for (int i = 0; i < this.Count; i++)
        //    {
        //        myList.Add([0]);
        //        myList.Add(this[1]);
        //        myList.Add([2]);

        //}

        //else
        //{
        //     for (int i = 0; i< .Count; i++)

        //    {
        //        myList.Add(this[0]);
        //        myList.Add([1]);
        //        myList.Add(this[2]);
        //    }
        //return myList;

    }
}


