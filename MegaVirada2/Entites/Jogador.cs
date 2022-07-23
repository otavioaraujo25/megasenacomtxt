using System;
using System.Collections.Generic;
using System.Text;

namespace MegaVirada.Entites
{
    class Jogador
    {
        public string Nome { get; set; }
        public List<int> Numeros { get; set; }

        public Jogador(string nome, List<int> numeros)
        {
            Nome = nome;
            Numeros = numeros;
        }
    }
}
