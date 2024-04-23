﻿namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício01();
            //Exercício02();
            Exercício03();
        }

        private static void Exercício01()
        {

            //-Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.
            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    vector[i] = valorInteiro;
                }
                else
                {
                    Console.WriteLine("Valor invalido. Tente novamente");
                    i--;
                }
            }
            imprimirInformacoes(vector);
        }
        static void imprimirInformacoes(int[] valorInteiro)
        {
            foreach (var Item in valorInteiro)
            {
                Console.WriteLine(Item);
            }
        }

        private static void Exercício02()
        {
            // - Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.
            int[] vector = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    vector[i] = valorInteiro;
                }
                else
                {
                    Console.WriteLine("Valor invalido. Tente novamente");
                    i--;
                }
            }
            int maiorNumero = vector[0];
            int menorNumero = vector[0];

            foreach (var Item in vector)
            {
                if (Item > maiorNumero)
                {
                    maiorNumero = Item;
                }
                if (Item < menorNumero)
                {
                    menorNumero = Item;
                }
            }
            Console.WriteLine($"O maior número é {maiorNumero} e o menor é {menorNumero}");

        }
    
        private static void Exercício03()
        {
            //- Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

            int[,] vector = new int[3, 3];
            for (int i = 0; i < vector.GetLength(0);i++)
            {
               for (int j = 0; j < vector.GetLongLength(0); j++)
                {
                    Console.WriteLine("Digite um número inteiro");
                    if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                    {
                        vector[i, j] = valorInteiro;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Tente novamente");
                        i--;
                    }
                }
            }
            for (int i = 0; i < vector.GetLength(0); i++)
            {
                for (int j = 0;j < vector.GetLongLength(0);j++)
                {
                    Console.WriteLine(vector[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void Exercício04()
        {
            /* -Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes de ambos os vetores, 
                armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante. */
        }

        private static void Exercício05()
        {
            // - Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.
        }

        private static void Exercício06()
        {
            /*- Busca de Dados em uma Matriz de Animais
            Suponha que você tenha uma matriz que representa uma lista de animais, onde cada linha contém as seguintes propriedades de um animal:
            Nome
            Espécie
            Idade
            Peso
            Escreva um programa em C# que permita ao usuário buscar animais por uma determinada propriedade (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca.
            // Matriz de animais [Nome, Espécie, Idade, Peso]
            string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
            }; */
        }
    }
}