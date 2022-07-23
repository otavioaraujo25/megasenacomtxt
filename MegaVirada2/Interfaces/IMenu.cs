using MegaVirada.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace MegaVirada.Interfaces
{
    class IMenu
    {
        MegaSena mega1 = new MegaSena();
        Arquivo arq1 = new Arquivo();
        Resultado result = new Resultado();
        List<Jogador> players = new List<Jogador>();
        public void declaracaoManual()
        {
            Console.Clear();
            Console.WriteLine("Diga seu nome:");
            string nome = Console.ReadLine();
            List<int> numeros = mega1.geradorManual();
            Jogador j1 = new Jogador(nome, numeros);
            players.Add(j1);
            arq1.saveDataLocal(players);
        }

        public void declaracaoAutomatica()
        {
            Console.Clear();
            Console.WriteLine("Diga seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos numeros quer gerar?");
            int escolha = int.Parse(Console.ReadLine());
            List<int> numeros = mega1.geradorAutomatico(escolha);
            if (numeros == null)
            {
                Console.WriteLine("NUMEROS NÃO GERADOS; Voltando para o menu, pressione para continuar...");
                Console.ReadKey();
            }
            else
            {
                Jogador j1 = new Jogador(nome, numeros);
                players.Add(j1);
                arq1.saveDataLocal(players);
            }
        }

        public void finalizarMega()
        {
            List<int> numeros = result.gerarResultado();
            Console.ReadKey();
            Console.Clear();
            arq1.saveMegaDay(numeros);
            result.mostrarResultado(players, numeros);
        }

        public void verificarArquivo()
        {
            Console.WriteLine("Digite o nome do arquivo que quer verificar! Ex: 16062021");
            arq1.verificarArquivo(Console.ReadLine());
        }
    }
}