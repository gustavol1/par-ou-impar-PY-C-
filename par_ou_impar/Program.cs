using System;

namespace par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" par ou ímpar");
            while (true)
            {
            Random random = new Random();
            Console.WriteLine("digite se quer par ou impar [P/i]");
            string poimp = Console.ReadLine();
            Console.Write("digite o numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int maquina = Convert.ToInt32(random.Next(10));
            int conta = num + maquina;
            Console.WriteLine($"seu numero foi {num} e o numero de seu oponente foi {maquina} com um total de {conta}");
            if (poimp == "p"){
                if (conta % 2 == 0)
                    {
                        Console.WriteLine("Você ganhou!!");
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu!!");
                        break;
                    }
                }
            else if (poimp == "i")
                {
                    if (conta % 2 == 1)
                    {
                        Console.WriteLine("Você ganhou!!");
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu!!");
                        break;
                    }
                }
            }

        }
    }
}
