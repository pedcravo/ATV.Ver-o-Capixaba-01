/*
Cenário: Verão Capixaba 01 -> 
• Faça um algoritmo para realizar as conversões de temperatura, de acordo 
com as formulas abaixo:

Celsius    ->  Fahrenheit |  F = C * 1,8 +32
Fahrenheit ->  Celsius    |  C = (F - 32)/1,8
Celsius    ->  Kelvin     |  K = C + 273,15
Kelvin     ->  Celsius    |  C = K - 273,15
 */

using System;

namespace Verão_Capixaba_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string medida1, medida2;
            double c, f, k;

            Console.WriteLine("Digite qual medida quer que seja convertida de acordo com a tabela abaixo:\nc = Celsius\nf = Fahrenheit\nk = Kelvin");
            medida1 = Console.ReadLine();

            Console.WriteLine("Digite para qual medida deseja converter de acordo com a tabela anterior:");
            medida2 = Console.ReadLine();

            if (medida1 == medida2)
            {
                Console.WriteLine("\nERRO:\nAs medidas a serem convertidas não podem ser iguais");
            }
            else if (medida1 == "c" & medida2 == "f")
            {
                Console.WriteLine("\nDigite a temperatura:");
                c = double.Parse(Console.ReadLine());
                f = (c * 1.8) + 32;
                Console.WriteLine("\n" + c + "C convertido para Fahrenheit é " + f + "F");
            }
            else if (medida1 == "c" & medida2 == "k") {
                Console.WriteLine("\nDigite a temperatura:");
                c = double.Parse(Console.ReadLine());
                k = c + 273.15;
                Console.WriteLine("\n" + c + "C convertido para Kelvin é " + k + "K");
            }
            else if (medida1 == "f" & medida2 == "c")
            {
                Console.WriteLine("\nDigite a temperatura:");
                f = double.Parse(Console.ReadLine());
                c = (f - 32) / 1.8;
                Console.WriteLine("\n" + f + "F convertido para Celsius é " + c + "C");
            }
            else if (medida1 == "k" & medida2 == "c") {
                Console.WriteLine("\nDigite a temperatura:");
                k = double.Parse(Console.ReadLine());
                c = k - 273.15;
                Console.WriteLine("\n" + k + "K convertido para Celsius é " + c + "C");
            }
            else {
            Console.WriteLine("\nERRO:\nAs medidas devem ser as contidas nesta lista\nc = Celsius\nf = Fahrenheit\nk = Kelvin");
            }
        }
    }
}
