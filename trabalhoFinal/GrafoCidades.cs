using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoFinal
{
    public class GrafoCidades
    {
        // Existem 15 cidades no mapa disponibilizado em roteiro:
        const int total_cidades = 15;
        Cidade[] cidades = new Cidade[total_cidades];
        int[,] distancias = new int[total_cidades, total_cidades];
        int qtdCidadesInseridas;

        public GrafoCidades()
        {
            // Inicializando a matriz de distâncias
            for (int i = 0; i < total_cidades; i++)
                for (int j = 0; j < total_cidades; j++)
                    distancias[i, j] = 0;

            qtdCidadesInseridas = 0;
        }

        public void AddCidade(string nome)
        {   
            cidades[qtdCidadesInseridas] = new Cidade(nome);
            qtdCidadesInseridas++;
        }

        public void AddDistancia(int cidadeInicial, int cidadeFinal, int distancia)
        {
            distancias[cidadeInicial, cidadeFinal] = distancia;
            distancias[cidadeFinal, cidadeInicial] = distancia;
        }

        public void MostrarCidade(string nome_cidade)
        {
            MessageBox.Show(nome_cidade);
        }

        public int[,] Distancias { get => distancias; set => distancias = value; }
    }
}
