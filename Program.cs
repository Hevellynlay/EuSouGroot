using System;

class Program
{
    const string FraseParaSair = "tchau";

    static void Main()
    {
        Console.WriteLine("--- Groot Chatbot ---");

        string pergunta;
        
        do
        {
            Console.Write("Pergunta: ");
            pergunta = Console.ReadLine()!;

            // Resposta do Groot
            Console.WriteLine($"Resposta: Eu sou Groot.");

        } while (pergunta.Trim().ToLower() != FraseParaSair);

        // Resposta final antes de sair
        Console.WriteLine("Eu sou Groot!");
    }
}

