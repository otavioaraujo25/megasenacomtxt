using System;
using System.Collections.Generic;
using System.Text;

namespace MegaVirada.Entites
{
    class MegaSena
    {

        public List<int> geradorAutomatico(int valor)
        {
            var numeros = new List<int>();
            var gerador = new Random();
            if (valor >= 6 && valor <= 15)
            {
                for (int i = 0; i < valor; i++)
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
                foreach (var item in numeros)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\nNUMEROS GERADOS! Presssione para continuar!");
                return numeros;
            }
            else
            {
                return null;
            }
        }

        public List<int> geradorManual()
        {
            string escolha = "";
            bool teste = false;
            int cont = 0;
            List<int> numeros = new List<int>();
            do
            {
                Console.Clear();
                Console.WriteLine("INSIRA UM NUMERO DE 1 A 60");
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 1 && numero <= 60)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        for (int j = 0; j < numeros.Count; j++)
                        {
                            if (numeros[j] == numero)
                            {
                                Console.WriteLine("Numero repetido!");
                                teste = true;
                            }
                        }
                        if (teste == false)
                        {
                            cont++;
                            Console.WriteLine("Foram digitados: " + cont + " Numeros");
                            numeros.Add(numero);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numero invalido!");
                }
                Console.WriteLine("Quer adicionar + numeros ? (SIM = S/ NÃO = N)");
                escolha = Console.ReadLine();
                if (escolha == "N")
                {
                    if (numeros.Count < 6)
                    {
                        escolha = "S";
                        Console.WriteLine("O minimo exigido é 6 e o maximo é 15; Pressione para continuar...");
                        Console.ReadKey();
                    }
                }
                if (escolha == "S")
                {
                    if (numeros.Count == 15)
                    {
                        escolha = "N";
                        Console.WriteLine("Numero maximo é 15; Pressione para continuar...");
                        Console.ReadKey();
                    }
                }
            } while (escolha != "N");
            return numeros;
        }
    }
}
