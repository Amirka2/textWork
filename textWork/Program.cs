using System;
using System.Collections.Generic;

namespace textWork
{
    internal class Program
    {
        public static int PunctMarks(string text)
        {
            int count = 0;
            char[] ch = text.ToCharArray();
            char check = ch[0];
            foreach (char det in ch)
            {
                if ((det == ',') || (det == '.')
                                 || ((det == '-') && (check == ' '))
                                 || (det == ':') || (det == ';')
                                 || (det == '!') || (det == '?')
                                 || (det == '(') || (det == ')')
                                 || (det == '"') || (det == '\''))
                {
                    count++;
                }
                check = det;
            }
            return count;
        } // Считаем количество знаков препинания

        public static string[] Sentences(string text)
        {
           string[] sentences = text.Split('.');
           return sentences;
        } // Выводим предложения по-отдельности

        public static string TheLongestWord(string text)
        {

            string[] words = Remover(text);
            int max = 0;
            string maxWord = " ";
            foreach (string word in words)
            {
                if (word.Length >= max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }

            return maxWord;
        } // Находим самое длинное слово

        public static string WordConverter(string word) // Изменяем слово в зависимости от четности его длины
        {
            int length = word.Length;
            if ((length % 2) == 0)
            {
                //word = word.Remove;
            }
            else
            {
                int centerInt = length / 2;
                char centerCh = word[centerInt];
                word = word.Replace(centerCh, '*');
            }

            return word;
        }
        public static string[] Remover(string text)
        {
            string[] words = text.Split(' ', '.', ',', '!', '?', '(', ')', '"', '\'', '*', ';', ':');
            return words;
        }

        /*public static string[] UniqueWords(string[] words)
        {
            
        }*/
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            var text = Console.ReadLine();

            Console.WriteLine("Знаки пунктуации:");
            Console.WriteLine(PunctMarks(text));
            
            Console.Write("Предложения: ");
            foreach (string sentence in Sentences(text))
            {
                Console.WriteLine(sentence);
            }
            Console.WriteLine("Самое длинное слово:");
            Console.WriteLine(WordConverter(TheLongestWord(text)));
            
            //Console.WriteLine("Уникальные слова:");

        }
    }
