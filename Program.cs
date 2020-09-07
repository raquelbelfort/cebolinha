using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Olá, usuário! Como será que o Cebolinha diria o famoso trava-língua 'O rato roeu a roupa do rei de Roma'? Tente escrever essa frase.");
            string cebolinha = Console.ReadLine().Replace("r" , "l") .Replace("R", "L");
            Console.WriteLine(cebolinha);
        }
    }
}
