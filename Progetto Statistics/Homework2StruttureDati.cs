using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Statistics
{
    internal class Homework2StruttureDati
    {
        public void PerformArrayOperations()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = 6;
            Array.Resize(ref array, array.Length - 1);
            bool existsInArray = Array.Exists(array, element => element == 3);
        }

        public void PerformListOperations()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            list.Add(6);
            list.Remove(3);
            bool existsInList = list.Contains(4);
        }

        public void PerformDictionaryOperations()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            dictionary["four"] = 4;
            dictionary.Remove("two");
            bool keyExists = dictionary.ContainsKey("three");
        }

        public void PerformSortedListOperations()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>
        {
            { 3, "three" },
            { 1, "one" },
            { 2, "two" }
        };
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            sortedList.Add(4, "four");
            sortedList.Remove(2);
            bool keyExists = sortedList.ContainsKey(1);
        }

        public void PerformHashSetOperations()
        {
            HashSet<string> hashSet = new HashSet<string> { "apple", "banana", "cherry" };
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
            hashSet.Add("date");
            hashSet.Remove("banana");
            bool existsInHashSet = hashSet.Contains("apple");
        }

        public void PerformSortedSetOperations()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 3, 1, 2 };
            foreach (var element in sortedSet)
            {
                Console.WriteLine(element);
            }
            sortedSet.Add(4);
            sortedSet.Remove(2);
            bool existsInSortedSet = sortedSet.Contains(1);
        }
        public void PerformQueueOperations()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            while (queue.Count > 0)
            {
                int item = queue.Dequeue();
                Console.WriteLine(item);
            }
            queue.Enqueue(4);
            bool existsInQueue = queue.Contains(3);
        }

        public void PerformStackOperations()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while (stack.Count > 0)
            {
                int item = stack.Pop();
                Console.WriteLine(item);
            }
            stack.Push(4);
            bool existsInStack = stack.Contains(2);
        }

        public void PerformLinkedListOperations()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("apple");
            linkedList.AddLast("banana");
            linkedList.AddLast("cherry");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            linkedList.AddLast("date");
            linkedList.Remove("banana");
            bool existsInLinkedList = linkedList.Contains("apple");
        }


        //--------------------------------------------------------------------esercizio 3-------------------------------------------
    
        public void GenerateAndAnalyzeRandomDistribution(int N, int k)
        {
            if (N <= 0 || k <= 0)
            {
                Console.WriteLine("N e k devono essere maggiori di zero.");
                return;
            }
            Random random = new Random();
            List<int> intervalCounts = new List<int>(k);
            for (int i = 0; i < k; i++)
            {
                intervalCounts.Add(0);
            }
            for (int i = 0; i < N; i++)
            {
                double randomValue = random.NextDouble();
                int intervalIndex = (int)(randomValue * k);
                if (intervalIndex >= 0 && intervalIndex < k)
                {
                    intervalCounts[intervalIndex]++;
                }
            }
            Console.WriteLine($"Distribuzione dei dati in {k} intervalli:");
            for (int i = 0; i < k; i++)
            {
                double lowerBound = (double)i / k;
                double upperBound = (double)(i + 1) / k;
                int count = intervalCounts[i];
                double frequency = (double)count / N;
                Console.WriteLine($"Intervallo [{lowerBound}, {upperBound}): {count} elementi, Frequenza: {frequency:P}");
            }
        }


    }

}

