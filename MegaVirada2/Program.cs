using MegaVirada.Interfaces;
using System;
using System.Collections.Generic;

namespace MegaVirada
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool status = false;
                int escolha;
                IMenu menu = new IMenu();
                do
                {
                    Console.Clear();
                    Console.WriteLine("-------- MegaSena da VIRADA ----------");
                    Console.WriteLine("----------- 31/12/2021 --------------");
                    Console.WriteLine("1 - Gerar Aposta Manual");
                    Console.WriteLine("2 - Gerar Aposta Automatica");
                    Console.WriteLine("3 - Finalizar Apostas do Dia");
                    Console.WriteLine("4 - Verificar vencedor de uma data");
                    Console.WriteLine("5 - Encerrar Menu");
                    escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            if (status == false)
                            {
                                menu.declaracaoManual();
                            }
                            else
                            {
                                Console.WriteLine("Apostas do dia já finalizada!");
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            if (status == false)
                            {
                                menu.declaracaoAutomatica();
                            }
                            else
                            {
                                Console.WriteLine("Apostas do dia já finalizada!");
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            if (status == false)
                            {
                                status = true;
                                menu.finalizarMega();
                            }
                            else
                            {
                                Console.WriteLine("Apostas do dia já finalizada!");
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            menu.verificarArquivo();
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Digito invalido!");
                            Console.ReadKey();
                            break;
                    }
                } while (escolha != 5);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
