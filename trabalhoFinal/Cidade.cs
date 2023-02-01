using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoFinal
{
    internal class Cidade
    {
        string nome_cidade;
        bool visitada;

        public Cidade(string nome)
        {
            nome_cidade = nome;
            visitada = false;
        }

        public string Nome_cidade { get => nome_cidade; set => nome_cidade = value; }
        public bool Visitada { get => visitada; set => visitada = value; }
    }
}
