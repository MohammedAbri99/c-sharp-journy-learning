using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class PhoneBook
    {
        string[] Names;
        long[] Numbers;
        int size;
        int cnt;

        //constructor
        public PhoneBook(int size)
        {
            this.size = size;
            this.Names = new string[size];
            this.Numbers = new long[size];
        }

        //size geter
        public void GetSize()
        {
            Console.WriteLine(this.size);
        }

        public void SetAll(string name,long number)
        {
            Names[cnt] = name;
            Numbers[cnt] = number;
            this.cnt ++;
        }

        public void displayContents()
        {
            Console.WriteLine("Your contacts:: \n");
            for (int i = 0; i < size; i++) 
            {
                if (Names[i] != null)
                {
                    Console.WriteLine($"{i+1} => Name: {this.Names[i]} || PhoneNumber: {this.Numbers[i]}");
                }
            }
        }
        public long GetNumberByName(string name)
        {
            for(int i = 0;i < size;i++)
            {
                if (this.Names[i]?.ToLower() == name?.ToLower()) 
                {
                    return this.Numbers[i];
                }
            }
            return 0;
        }
        private int FindNameIndex(string name)
        {
            for (int j = 0; j < Names.Length; j++)
            {
                if (Names[j] == name)
                {
                    return j;
                }
            }
            return -1;
        }

        public long this[string name,bool add=false] 
        {
            get 
            { 
                int index = FindNameIndex(name);
                return Numbers[index]; 
            }
            set 
            {
                if (!add)
                {
                    int index = FindNameIndex(name);
                    Numbers[index] = value;
                }
                else
                {
                    Names[cnt] = name;
                    Numbers[cnt] = value;
                    this.cnt++;
                }
            }
        }



    }
}
