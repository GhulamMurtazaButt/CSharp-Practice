// Arrays in C# have a restriction, once they are declared we cannot change their size. If you have an array
// of size = 10, you cannot add 11 elements in it. In this assignment we’ll create an abstraction to overcome
// this limitation. We call this class ArrayList.
// The idea is that you create a class that has an int array as an instance variable (you can create other
// instance variables too if you need). The array list will have following features.
// Feel free to create any private methods or instance variables.
// Write a program to use these methods and demonstrate the capabilities of your arraylist
using System;
using System.Globalization;


namespace Week5A02
{
    public class ArrayList
    {

        int[] myarr;
        int index = 0;
        int topIndex = 0;
        public ArrayList(int initialCapacity)
        {

            myarr = new int[initialCapacity];
            topIndex = initialCapacity;
        }


        public ArrayList()
        {
            myarr = new int[10];
        }

        public void Add(int element)
        {

            myarr[index] = element;
            index++;
            ArrayDouble();

        }
        public void Remove(int element)
        {
            bool found = false;
            for (int i = 0; i < topIndex; i++)
            {
                if (myarr[i] == element)
                {
                    found = true;
                    for (int j = i; j < index; j++)
                    {
                        myarr[j] = myarr[j + 1];

                    }
                    index--;
                    break;
                }

            }
            if (found == false)
            {
                Console.WriteLine("Element Not Found");
            }
            if (topIndex / 2 - 1 == index)
            {
                int newtopIndex = index;
                int[] newarray = new int[newtopIndex];

                for (int i = 0; i < index; i++)
                {
                    newarray[i] = myarr[i];
                }

                myarr = newarray;
                topIndex = newtopIndex;
            }
        }

        public void RemoveRange(int fromIndex, int toIndex)
        {


            for (int i = fromIndex; i < index; i++)

            {
                toIndex++;
                myarr[i] = myarr[toIndex];
                index--;
            }
        }

        public void IndexOf(int element)
        {
            bool found = false;
            for (int i = 0; i < topIndex; i++)
            {
                if (myarr[i] == element)
                {
                    found = true;
                    Console.WriteLine("The idex of element is: {0}", i);
                    break;
                }

            }
            if (found == false)
            {
                Console.WriteLine("Element Not Found");
            }
        }

        public int get(int index)
        {
            return myarr[index];
        }

        public void InsertElementAt(int ind, int element)
        {

            ArrayDouble();

            for (int i = index; i >= ind; i--)
            {

                myarr[i + 1] = myarr[i];

            }
            myarr[ind] = element;
            index++;
        }

        public void AddElementAt(int index, int element)
        {
            myarr[index] = element;
        }

        public bool IsEmpty()
        {
            return index == 0;
            
        }

        public int Count()
        {
            return index;
        }

        public bool Contains(int n)
        {
            for (int i = 0; i < index; i++)
            {
                if (myarr[i] == n)
                {
                    return true;
                }
            }
            return false;
        }

        public void Merge(ArrayList a)
        {
            for (int i = 0; i < a.index; i++)
            {
                Add(a.myarr[i]);
            }
        }

        public void ArrayDouble()
        {
            if (index >= topIndex)
            {
                int newtopIndex = index * 2;
                int[] newarray = new int[newtopIndex];

                for (int i = 0; i < index; i++)
                {
                    newarray[i] = myarr[i];
                }

                myarr = newarray;
                topIndex = newtopIndex;
            }
        }
        public void print()
        {
            Console.WriteLine("Your array data is :");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(myarr[i]);
            }
        }





        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(10);

            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
         
            
            Console.WriteLine(array.Count());
            //ArrayList array2 = new ArrayList(5);
            //array2.Add(6);
            // array2.Add(7);
            // array2.Add(8);
            //  array2.Add(9);
            //  array2.Add(10);


            //   array.Merge(array2);
            // array.Remove(3);
            // array.RemoveRange(4, 8);
            // array.IndexOf(12);
            // Console.WriteLine(array.get(2));
            // array.InsertElementAt(6, 16);

            // Console.WriteLine(array.Contains(4));
            // Console.WriteLine(array.Count());
            // Console.WriteLine(array.IsEmpty());

            array.print();


        }
    }
}