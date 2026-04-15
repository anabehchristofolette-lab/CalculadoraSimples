using System;

// Namespace organiza nosso código
namespace CalculadoraSimples
{
    class program
    {
        static void Main(string[] args)
        {
            // Exibe mensagem no console
            Console.WriteLine("---calculadora SENAI ---");
            
            Console.Write("Digite o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Realiza a soma e exibe o resultado
            double soma = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {soma}");
        }
    }
}