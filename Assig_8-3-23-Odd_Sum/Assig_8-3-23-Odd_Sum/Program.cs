using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please type array elements divided by blank");
string[] inputArray=Console.ReadLine().Trim().Split(' ');
Console.WriteLine("Printing elements");

for (int i = 0; i < inputArray.Length; i++)
{
    Console.WriteLine(inputArray[i]);
}
//int[] arrNoDup=new int[inputArray.Length];
//for (int i = 0; i < inputArray.Length; i++)
//{
//    for (int j = i + 1; j < inputArray.Length; j++)
//    {
//        if (inputArray[i] == inputArray[j])
//        { 
//        Dup=true;
//        }
//    }
//}
int[] integerArray = Array.ConvertAll(inputArray, int.Parse);
IEnumerable<int> distinctElements = integerArray.Distinct();
Console.WriteLine("Printing array removing duplicates");
// Iterate over the distinct elements and print them.
foreach (int element in distinctElements)
{
    Console.WriteLine(element);
}




