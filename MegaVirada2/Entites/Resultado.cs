using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MegaVirada.Entites
{
    class Resultado
    {
        public List<int> gerarResultado()
        {
            var numeros = new List<int>();
            var gerador = new Random();
            for (int i = 0; i < 6; i++)
            {
                bool teste = false;
                int numero = gerador.Next(1, 15);
                for (int j = 0; j < 1; j++)
                {
                    for (int h = 0; h < numeros.Count; h++)
                    {
                        if (numeros[h] == numero)
                        {
                            teste = true;
                            i--;
                        }
                    }
                    if (teste == false)
                    {
                        numeros.Add(numero);
                    }
                }
            }
            Console.WriteLine("NUMEROS GERADOS!");
            foreach (var item in numeros)
            {
                Console.Write(item + " ");
            }
            return numeros;
        }

        public void mostrarResultado(List<Jogador> j1, List<int> numeros)
        {
            int cont = 0;
            bool status = false;
            foreach (var item in j1)
            {
                foreach (var item2 in item.Numeros)
                {
                    foreach (var item3 in numeros)
                    {
                        if (item2 == item3)
                        {
                            cont++;
                        }
                    }
                }
                if (cont >= 4)
                {
                    status = true;
                    string Date = DateTime.Now.ToString("ddMMyyyy");
                    string Caminho = @"C:\Users\Otavio\Desktop\Faculdade 2 Ano\POO\2 Bimestre\MegaDaVirada\Docs\" + "R" + Date + ".txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(Caminho, true))
                        {
                            sw.Write(item.Nome + ": ");
                            if (cont == 4)
                            {
                                sw.Write("Quadra, ");
                            }
                            else if (cont == 5)
                            {
                                sw.Write("Quina, ");
                            }
                            else
                            {
                                sw.Write("Sena, ");
                            }
                            foreach (var item2 in item.Numeros)
                            {
                                sw.Write(item2 + " ");
                            }
                            sw.WriteLine();
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("An error oCurred");
                        Console.WriteLine(e.Message);
                    }
                }
                cont = 0;
            }
            if (status == false)
            {
                Console.WriteLine("Não houve nenhum vencedor!");
            }
            else
            {
                try
                {
                    string Date = DateTime.Now.ToString("ddMMyyyy");
                    string Caminho = @"C:\Users\Otavio\Desktop\Faculdade 2 Ano\POO\2 Bimestre\MegaDaVirada\Docs\" + "R" + Date + ".txt";
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
                    Console.WriteLine("An error oCurred");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
