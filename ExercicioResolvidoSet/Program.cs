using System;
using System.IO;
using ExercicioResolvidoSet.Entities;
using System.Collections.Generic;

namespace ExercicioResolvidoSet
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<RegistroLog> conjunto = new HashSet<RegistroLog>();

            Console.Write("Informe o caminho completo do arquivo: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string[] origem = File.ReadAllLines(path);
                    foreach (string line in origem)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();

                    while (!sr.EndOfStream)
                    {                   
                        string[] linha = sr.ReadLine().Split(' ');
                        string nome = linha[0]; //<--na posição 0 vai receber a primeira parte da linha dividida pelo espaço definido no Split
                        DateTime instant = DateTime.Parse(linha[1]); //<--na posição 1 recebe a segunda parte conforme acima
                        conjunto.Add(new RegistroLog { Username = nome, Instant = instant });
                    }
                }
                Console.WriteLine("Quantos usuários diferentes acessaram? ");
                Console.WriteLine("Total de usuários: " + conjunto.Count);

                Console.ReadKey();
           
                

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
