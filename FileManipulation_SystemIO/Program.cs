using System;

using System.IO;

namespace FileManipulation_SystemIO
{
    class Program
    {
        static void Main(String[] args)
        {
            //===========adds to file ==========
            string filePath = "../new-data.txt";
            string addCarFilePath = "../new-car-data.txt";
            //========creates new file=============
            string newFilePath = "../new-data.txt";
            // string carFilePath = "../new-car-data.txt";

            // Console.WriteLine("Hello World");
            Console.Clear();
            FileReadAllTextAsBytes(filePath);
            FileReadAllText(filePath);
            FileReadAllTextAsArray(filePath);
            FileAddSomeLines(addCarFilePath);
            FileReadAllText(filePath);
            // FileCreateNewFile(newFilePath); //create new file
            // FileCreateNewFile(carFilePath); //create new file
            // FileReadAllText(newFilePath);
        }

        static void FileCreateNewFile(string file)
        {
            string[] words = { "I", "Have", "The", "Power!" };
            try
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    try
                    {
                        foreach (string word in words)
                        {
                            sw.WriteLine(word);
                            // sw.WriteLine("\n");
                        }
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                    finally
                    {
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }

        static void FileReadAllTextAsBytes(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);
            foreach (byte character in bytes)
            {
                Console.Write($"{character}");
            }
        }

        static void FileReadAllText(string file)
        {
            Console.WriteLine("-----READ AS STRING-----");
            string myFileContents = File.ReadAllText(file);
            Console.WriteLine(myFileContents);
        }

        static void FileReadAllTextAsArray(string file)
        {
            Console.WriteLine("-----Read as Array----");
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static void FileAddSomeLines(string file)
        {
            Console.WriteLine("------Add Lines-----");
            // string phrase = "He has more power than he thinks!\n";
            string phrase = "He-Man needs BATTLECAT!\n";
            File.AppendAllText(file, "\n");
            File.AppendAllText(file, phrase);

            // string[] words = {
            //     "sunny",
            //     "hot",
            //     "loud"
            // };

            // File.AppendAllText(file, "\n");
            // File.AppendAllLines(file, words);

            // File.Delete(file); // to delete the entire file
        }

    }
}