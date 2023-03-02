using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaZaIzpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chisla: ");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrintCount(numbers);

            Console.Write("Vuvedi chisla na masiv1: ");
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayTolistOne(numbers, arr1);

            Console.Write("Vuvedi chislo za proverka: ");
            int num = int.Parse(Console.ReadLine());
            IsnumList(numbers, num);

            Console.Write("Vuvedi chisla na masiv2: ");
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayTolistTwo(numbers, arr2); 

        }

        static void AddArrayTolistTwo(List<int> numbers, int[] arr2)
        {
            numbers.InsertRange(3, arr2);
            Console.WriteLine($"Chislata na masiv2 sa: {string.Join(" ", numbers)}");
            numbers.Sort();
            Console.WriteLine($"Chislata na lista sa: {string.Join(" * ", numbers)}");
        }

        static void IsnumList(List<int> numbers, int num)
        {
            if (numbers.Contains(num))
            {
                Console.WriteLine($"Chisloto {num} e na indeks {numbers.IndexOf(num)}");
            }
        }

        static void AddArrayTolistOne(List<int> numbers, int[] arr1)
        {
            numbers.AddRange(arr1);
            numbers.Sort();
            Console.WriteLine($"Chislata na masiv1 sa: {string.Join(" ", numbers)}");
        }

        static void PrintCount(List<int> numbers)
        {
            Console.WriteLine($"Chislata v masiva sa: {numbers.Count}");
        }
    }
}
