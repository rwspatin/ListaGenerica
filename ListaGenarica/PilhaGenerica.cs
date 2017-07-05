using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoRoberto
{
    class PilhaGenerica<T>
    {
        class pilha{
            //tamanho do vetor a ser criado a pilha
            int TAM;
            T[] p = new T[TAM]; //Não sei se da certo isso, parece que não
            int topo = 0;
        }

        static Boolean Empilhar(T[] p, ref int topo, T dado)
        {
            Boolean result = false;
            //setar proximo que entra no inicio
            if (topo < TAM)
            {
                p[topo] = dado;
                topo += 1;
                result = true;
            }
            return result;
        }

        static Boolean Desempilhar(T[] p, ref int topo, ref T dado)//ref T dado é qual valor deseja retirar
        {
            Boolean result = false;
            //setar proximo que entra no inicio
            if (topo > 0)
            {
                dado = p[topo-1];
                result = true;
            }
            return result;
        }
    }
}
