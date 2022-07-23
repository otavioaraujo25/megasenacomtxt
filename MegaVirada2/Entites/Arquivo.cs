using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MegaVirada.Entites
{
    class Arquivo
    {
        public string Caminho { get; set; }

        public void saveDataLocal(List<Jogador> j1)
        {
            string Date = DateTime.Now.ToString("ddMMyyyy");

            Caminho = @"C:\Users\Otavio\Desktop\Faculdade 2 Ano\POO\2 Bimestre\MegaDaVirada\Docs\" + "A" + Date + ".txt";
            try
            {

                using (StreamWriter sw = new StreamWriter(Caminho, false))
                {
                    foreach (var item in j1)
                    {
                        sw.Write(item.Nome + ",  ");
                        foreach (var item2 in item.Numeros)
                        {
                            sw.Write(item2 + " ");
                        }
                        sw.WriteLine();
                    }
                }
                Caminho = @"C:\Users\Otavio\Desktop\Faculdade 2 Ano\POO\2 Bimestre\MegaDaVirada\Docs\" + "C" + Date + ".txt";
                using (StreamWriter sw = new StreamWriter(Caminho, false))
                {
                    var count = j1.Count;
                    sw.Write(count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public void saveMegaDay(List<int> numeros)
        {
            string Date = DateTime.Now.ToString("ddMMyyyy");
            Caminho = @"C:\Users\Otavio\Desktop\Faculdade 2 Ano\POO\2 Bimestre\MegaDaVirada\Docs\" + "R" + Date + ".txt";
            try
            {

                using (StreamWriter sw = new StreamWriter(Caminho, false))
                {
                    //sw.Write("Resultado Do Dia: ");
                    foreach (var item in numeros)
                    {
                        sw.Write(item + " ");
                    }
                    sw.WriteLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public void verificarArquivo(string nome)
        {
            try
            {
                Console.Clear();
                string Caminho = @"C:\Users\Otavio\Desktop\Faculdade 2 Ano\POO\2 Bimestre\MegaDaVirada\Docs\" + "R" + nome + ".txt";
                using (StreamReader sr = File.OpenText(Caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}