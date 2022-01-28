using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    class Program
    {
        // Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
        //Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания, слова разделены пробелом");
            string sentence = Console.ReadLine();
            sentence = sentence.Replace(" ", "");
            sentence = sentence.ToLower();
            string palindrome = "";
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                palindrome += sentence[i];
            }
            if (sentence == palindrome)
            {
                Console.WriteLine("Предложение палиндром");
            }
            else
            {
                Console.WriteLine("Предложение не палиндром");
            }
            Console.ReadKey();
        }
    }
}
