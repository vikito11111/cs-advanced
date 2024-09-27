using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCounterDictionary = new Dictionary<string, int>();

            using (StreamWriter textWriter = new StreamWriter(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\03. Word Count\counter.txt"))
            {
                using (StreamReader wordReader = new StreamReader(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\03. Word Count\words.txt"))
                {
                    while (!wordReader.EndOfStream)
                    {
                        string[] words = wordReader.ReadLine()
                            .Split(' ')
                            .ToArray();

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (!wordCounterDictionary.ContainsKey(words[i]))
                            {
                                wordCounterDictionary.Add(words[i], 0);
                            }
                        }

                        for (int i = 0; i < words.Length; i++)
                        {
                            using (StreamReader textReader = new StreamReader(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\03. Word Count\text.txt"))
                            {
                                while (!textReader.EndOfStream)
                                {
                                    string lineOfText = textReader.ReadLine()
                                        .ToLower();

                                    if (lineOfText.Contains(words[i]))
                                    {
                                        wordCounterDictionary[words[i]]++;
                                    }
                                }
                            }
                        }

                        foreach (var word in wordCounterDictionary.OrderByDescending(x => x.Value))
                        {
                            textWriter.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
                
            }
        }
    }
}