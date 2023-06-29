using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkillboxHomework5_1
{
    internal class Program
    {
        /// <summary>
        /// Выводит в консоль массив слов
        /// </summary>
        /// <param name="text"></param>
        static void PrintArray(string[] text)
        {
            foreach (var e in text)
                Console.WriteLine(e);
            Console.ReadKey();
        }

        /// <summary>
        /// Разделяет строку на массив слов, удаляя пробелы и знаки
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            int countOfWords = 0;
            string[] splitedText = new string[33];
            char[] chars= text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (chars[i] != ' '& chars[i] != ',' & chars[i] != '.' & chars[i] != '!' & chars[i] != '?' & chars[i] != ';' & chars[i] != ':' & chars[i] != '"' & chars[i] != '-')
                {

                    splitedText[countOfWords] += chars[i];
                }
                else
                {
                    if (!(string.IsNullOrEmpty(splitedText[countOfWords])))
                    {
                        countOfWords++;
                        continue;
                    }
                }
            }

            string[] outputArray = new string[countOfWords + 1];
            for (int i = 0; i <= countOfWords; i++)
            {
                outputArray[i] = splitedText[i];
            }


            return outputArray;
        }

        /// <summary>
        /// Возращает массив слов в обратном порядке без знаков препинания
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] Reverse(string text)
        {
            string[] textPrimal = SplitText(text);
            string[] outputText= new string[textPrimal.Length];

            for (int i = 0,k= textPrimal.Length-1; i < textPrimal.Length&k>=0; i++,k--)
            {
                outputText[i] = textPrimal[k];
            }
            return outputText;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст (максимум 33 слова): ");
            string text = Console.ReadLine();

            PrintArray(Reverse(text));

            
        }
    }
}
