using System;

namespace MyArrayApp
{
    
    public interface IOutput
    {
        void Show();                 
        void Show(string info);     
    }

    
    public class MyArray : IOutput
    {
        private int[] array;

        
        public MyArray(int[] array)
        {
            this.array = array;
        }

        
        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        
        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 2, 9, 5 };

            MyArray myArray = new MyArray(numbers);

            
            myArray.Show();

            
            myArray.Show("Це мій масив чисел:");
        }
    }
}





