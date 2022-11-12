using System;

namespace curso
{
    class Progam
    {
        static void Main(string[] args) {

            Console.WriteLine("       WHILE é recomendada quando não se sabe previamente a quantidade de repetições ");
            Console.WriteLine(" ");

            Console.WriteLine("Digite um numero, quando o número 0 for digitado será somado todos os números ");

            int x, soma;

            x = int.Parse(Console.ReadLine());
            soma = 0;
            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma de todos os números digitados é: " + soma);
            Console.ReadLine();
           
        }
    }
}