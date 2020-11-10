using System;
using System.IO;

namespace ExercicioResolvidoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caminho completo do arquivo: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        Console.WriteLine(linha);
                    }

                    Console.ReadKey();
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
