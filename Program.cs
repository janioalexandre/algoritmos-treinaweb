using System;

namespace algoritmos_treinaweb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            var nomes = new string[5];
            var letras = new char[]{ 'A', 'B', 'C' };

            /*
            Console.WriteLine(letras[0]);
            Console.WriteLine(letras[1]);
            Console.WriteLine(letras[2]);
            */

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            /*
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);
                        
            for(int i = 0; i < letras.Length; i++)
            {
                Console.WriteLine(letras[i]);
            }
            */

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

            /*
            for(int i = 0; i < itens.Length; i++)
            {
                Console.WriteLine(itens[i]);

                if(itens[i] == itemBuscado)
                {
                    Console.WriteLine($"Posição do item buscado: {i}");
                    break;
                }
            }
            */
            
            Console.WriteLine(BuscarItem(itens, itemBuscado));
        }
    }    
}