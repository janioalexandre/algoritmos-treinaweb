using System;

namespace algoritmos_treinaweb
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numeros = new int[5];
            var nomes = new string[5];
            var letras = new char[]{ 'A', 'B', 'C' };
            
            Console.WriteLine(letras[0]);
            Console.WriteLine(letras[1]);
            Console.WriteLine(letras[2]);

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;
            
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);
                        
            for(int i = 0; i < letras.Length; i++)
            {
                Console.WriteLine(letras[i]);
            }
            
            
            static int BuscarItem(int[] array, int itemBuscado)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] == itemBuscado)
                    {
                        return i;
                    }
                }
                return -1;
            }

            var itens = new int[]{ 5, 10, 15, 20, 25};

            var itemBuscado = 20;

            
            for(int i = 0; i < itens.Length; i++)
            {
                Console.WriteLine(itens[i]);

                if(itens[i] == itemBuscado)
                {
                    Console.WriteLine($"Posição do item buscado: {i}");
                    break;
                }
            }

            Console.WriteLine(BuscarItem(itens, itemBuscado));
            
            
            var vetor = new int[]{ 4, 1, 5, 3, 2};

            for (int i = 0; i < vetor.Length; i++)
            {
                var menor = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }

                if (menor != i)
                {
                    var auxiliar = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = auxiliar;    
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{ vetor[i] }");
            }
            */

            // Busca binária
            var vetor = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var buscado = 2;
            var inicio = 0;
            var fim = vetor.Length -1;
            var indiceBuscado = -1;
            
            while(inicio <= fim)
            {
                var meio = (int)((inicio + fim) / 2);

                if (buscado == vetor[meio])
                {
                    indiceBuscado = meio;
                    break;
                }
                else if (buscado > vetor[meio])
                {
                    meio = meio + 1;
                }
                else 
                {
                    fim = meio -1;
                }
            }

            if (indiceBuscado == -1)
            {
                Console.WriteLine("Elemento não localizado.");
            }
            else
            {
                Console.WriteLine($"O elemento de valor { buscado } encontra-se no índice { indiceBuscado }");
            }
        }
    }    
}