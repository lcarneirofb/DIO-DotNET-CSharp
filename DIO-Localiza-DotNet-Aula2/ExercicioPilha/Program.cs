using System;
using ExercicioPilha.FolderExample;

namespace ExercicioPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            var pilha_teste = new Pilha();
            pilha_teste.Empilha(1);
            pilha_teste.Empilha(10);
            pilha_teste.Empilha(100);

            Console.WriteLine("Desempilhando o elemento: "+ pilha_teste.Desempilha());
            Console.WriteLine("Desempilhando o elemento: "+ pilha_teste.Desempilha());
            Console.WriteLine("Desempilhando o elemento: "+ pilha_teste.Desempilha());

            //Teste Exception Throw
            Console.WriteLine("Desempilhando o elemento: "+ pilha_teste.Desempilha());
        }
    }
}
