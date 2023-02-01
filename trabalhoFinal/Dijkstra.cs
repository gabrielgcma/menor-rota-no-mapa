using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoFinal
{
    public class Dijkstra
    {
        int infinitoInt = Int32.MaxValue;

        int[] menoresDistancias;
        int[] cidadesAnteriores;
        List<int> cidadesNaoVisitadas = new();
        List<int> anteriores = new();

        public int[] MenoresDistancias { get => menoresDistancias; }
        public int[] CidadesAnteriores { get => cidadesAnteriores; }
        public List<int> Anteriores { get => anteriores; set => anteriores = value; }

        public Dijkstra(int[,] matrizDistancias, int num_cidades, int cidadeOrigem, int cidadeDestino)
        {
            cidadesAnteriores = new int[num_cidades];
            menoresDistancias = new int[num_cidades];

            for (int i = 0; i < num_cidades; i++)
            {
                cidadesNaoVisitadas.Add(i);
                menoresDistancias[i] = infinitoInt;
            }

            menoresDistancias[cidadeOrigem] = 0;

            // Gerar info sobre as menores distâncias e caminhos 
            while (cidadesNaoVisitadas.Count > 0)
            {
                int cidadeAtual = getCidadeMaisProx();

                for (int i = 0; i < num_cidades; i++)
                {
                    if (matrizDistancias[cidadeAtual, i] > 0) // procurando cidades vizinhas
                    {
                        // Caso a menor distância conhecida, da origem até a cidade vizinha desta atual
                        // seja maior que a calculada, atualizamos-na
                        if (menoresDistancias[i] > 
                            menoresDistancias[cidadeAtual] + matrizDistancias[cidadeAtual, i])
                            // matrizDistancias[cidadeAtual, i] é a distância entre
                            // a cidade atual e uma vizinha.
                            // menoresDistancias[cidadeAtual] é a menor distância até a 
                            // cidade atual (da origem).
                        {
                            menoresDistancias[i] =
                            menoresDistancias[cidadeAtual] + matrizDistancias[cidadeAtual, i];

                            cidadesAnteriores[i] = cidadeAtual;
                        }
                    }
                }
            }

            // preencher as cidades anteriores até o destino:
            int cidadeAnterior = cidadesAnteriores[cidadeDestino];
            while (cidadeAnterior != cidadeOrigem)
            {
                anteriores.Add(cidadeAnterior);
                cidadeAnterior = cidadesAnteriores[cidadeAnterior];
            }
        }

        public int getCidadeMaisProx()
        {
            // Retorna a cidade não visitada com a menor distância do começo
            int menorDistanciaConhecida = infinitoInt;
            int cidadeMaisProxima = -1;
            
            foreach (int cidade in cidadesNaoVisitadas)
            {
                if (menoresDistancias[cidade] <= menorDistanciaConhecida)
                {
                    menorDistanciaConhecida = menoresDistancias[cidade];
                    cidadeMaisProxima = cidade;
                }
            }

            cidadesNaoVisitadas.Remove(cidadeMaisProxima);

            return cidadeMaisProxima;
        }
    }
}
