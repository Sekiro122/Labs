using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int myNumber = 777;
                double myPrice = 99.99;
                char myLetter = 'X';

                int* pointerToNumber = &myNumber;
                double* pointerToPrice = &myPrice;
                char* pointerToLetter = &myLetter;

                Console.WriteLine($"myNumber  = {myNumber}  (адрес: {(long)pointerToNumber:X})");
                Console.WriteLine($"myPrice   = {myPrice} (адрес: {(long)pointerToPrice:X})");
                Console.WriteLine($"myLetter  = {myLetter}   (адрес: {(long)pointerToLetter:X})");

                *pointerToNumber = 111;        
                *pointerToPrice = 49.50;        
                *pointerToLetter = 'Z';          

                Console.WriteLine($"myNumber  = {myNumber}  (адрес: {(long)pointerToNumber:X})");
                Console.WriteLine($"myPrice   = {myPrice} (адрес: {(long)pointerToPrice:X})");
                Console.WriteLine($"myLetter  = {myLetter}   (адрес: {(long)pointerToLetter:X})");
            }
        }
    }
}