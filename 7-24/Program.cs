using System;

namespace RevatureFirstProject
{
    class Program
    {
        public struct Customer
        {
           public  int Id;
           public string FirstName;
            public string LastName;
            public CustomerStatus Status;
        }

        public enum CustomerStatus
        {
            New = 1,
            AwaitingActivation = 2,
            Activated = 3,
            DeActivated = 4
        }

        static void Main(string[] args)
        {
            Customer cust1 = new Customer();

            cust1.Id = 101;
            cust1.FirstName = "Andrew";
            cust1.LastName = "Zinke";
            cust1.Status = CustomerStatus.New;
            Console.WriteLine($"{cust1.Id} - {cust1.FirstName} - {cust1.LastName} - {cust1.Status}");        
        } // end of main

        //method to sort an array (use Array.Sort instead, this was just a training excersize)
        static void SortArray(int[] x)
        {
            for(int i = 0; i < x.Length-1;i++)
            {
                for(int j = i+1; j < x.Length;j++)
                {
                    if(x[i] < x[j])
                    {
                    Swap(ref x[i] , ref x[j]);
                    }
                }
            }
        }


        //method to sort a 2d array (incomplete, was just messing around)
        static void SortMultiArray(int[,] x)
        {
            int smallest;
            for(int i = 0;i < 3; i++)
            {
                for(int j = 0; j < 2; j++){

                    smallest = x[i,j];
                    if( x[i,j] < x[i,j])
                    {
                        
                    }
                }
            }
        }

          //method to swap numbers, uses reference variables

        static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x=y;
            y=temp;
        }
    } //end of class
} //end of namespace


        //stuff that was once in main that was taken out over the course of the day to clean up the main area
            /* 
            int i = 15;
            int j = 3;
            int i = 10;
            int j = 5;
            int[] numbers = new int[]{10,2,5,8,1};
            String name = "Andrew";
            bool isValid = false;
            Console.WriteLine ("I = " + i);
            Console.WriteLine("j = {0}", j);
            Console.WriteLine($"{name}");
            Console.WriteLine($"Valid = {isValid}");
            Console.WriteLine("Hello World!");

            numbers[3] = 25;
            int[,] coords  = new int[,] { {10,2}, {20,14}, {13,19}};

            for(int k = 0; k < 3; k++){
                for(int l =0; l < 2; l++){
                    Console.WriteLine(coords[k,l]);
                }
            }
            SortMultiArray(coords);
            Console.WriteLine("Sorted Array:");
            for(int k = 0; k < 3; k++){
                for(int l =0; l < 2; l++){
                    Console.WriteLine(coords[k,l]);
                }
            }
            Console.WriteLine($"i ={i} and j = {j}");
            Swap(ref i,ref j);
            Console.WriteLine($"i ={i} and j = {j}");

            while(j<i){
                j++;
            }

            do
            {
                i--;
            }while(i > 0);

            */
