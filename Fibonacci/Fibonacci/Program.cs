class Program
{
    static void Main()
    {
        long termo1 = 0;
        long termo2 = 1;
        long termo3 = 1;
        long[] sequencia = new long[91];
        sequencia[0] = termo1;
        sequencia[1] = termo2;
        sequencia[2] = termo3;
        Console.WriteLine("Digite um número para verificar se ele pertence aos 90 primeiros termos da sequência de Fibonacci: ");
        long entrada = long.Parse(Console.ReadLine());        
        
        for(int i = 3; i < 90; i++)
        {
            termo1 = termo2;
            termo2 = termo3;
            termo3 = termo1 + termo2;
            sequencia[i] = termo3;
        }
        
        if (sequencia.Contains(entrada))
            Console.WriteLine("O número pertence a sequência de Fibonacci.");
        else
            Console.WriteLine("O número não pertence a sequência de Fibonacci.");                            
    }
}

