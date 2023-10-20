using System;

class Calculadora
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair \n");

            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha >= 1 && escolha <= 4)
            {
                Console.WriteLine("Digite o primeiro número: \n");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: \n");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (escolha)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("Resultado: \n" + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("Resultado: \n" + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("Resultado: \n" + resultado);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("Resultado: \n" + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero. \n");
                        }
                        break;
                }
            }
            else if (escolha == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Escolha inválida. Tente novamente. \n");
            }
        }
    }
}