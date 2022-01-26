using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja calcular?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicacao");
        Console.WriteLine("5 - Sair");
        // Console.WriteLine("6 - Agradecemos por usar nosso sistema :)");

        Console.WriteLine("-------------------");
        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());

        switch(res){
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            case 5: Final(); System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
        static void Soma() {
        {
            Console.Clear();
            Console.WriteLine("Você escolheu somar :)");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro valor:");
            var v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");       
            float resultado = v1 + v2;  
            Console.WriteLine($"O resultado da soma é {resultado}"); 
            Console.ReadKey();
            Menu();          

        }
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();  

        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();  

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

           Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();  

        }
        static void Final()
        {
            Console.WriteLine("Agradecemos por usar nosso sistema :)");
        }   
    }
}