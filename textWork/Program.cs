using System;
using System.Collections.Generic;

namespace textWork
{
    internal class Program
    {
        public static int punctMarks(string text)
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

            string[] words = remover(text);
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

        public static string wordConverter(string word) // Изменяем слово в зависимости от четности его длины
        {
            int length = word.Length;
            if ((length % 2) == 0)
            {
                word = word.Remove;
            }
            else
            {
                int centerInt = length / 2;
                char centerCh = word[centerInt];
                word = word.Replace(centerCh, '*');
            }

            return word;
        }
        public static string[] remover(string text)
        {
            string[] words = text.Split(' ', '.', ',', '!', '?', '(', ')', '"', '\'', '*', ';', ':');
            return words;
        }

        /*public static string[] uniqueWords(string[] words)
        {
            foreach (string word in words)
            {
                for (int i = 0; i <= words.Length; i++)
                {
                    if (word == words[i])
                    {
                        words.Remove(word[i]);
                    }
                }
            }
        }*/
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            var text = Console.ReadLine();

            Console.WriteLine("Знаки пунктуации:");
            Console.WriteLine(punctMarks(text));
            
            Console.Write("Предложения: ");
            foreach (string sentence in Sentences(text))
            {
                Console.WriteLine(sentence);
            }
            Console.WriteLine("Самое длинное слово:");
            Console.WriteLine(wordConverter(TheLongestWord(text)));
            
            Console.WriteLine("Уникальные слова:");

        }
    }
}