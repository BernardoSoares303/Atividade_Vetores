public class Atividade1
{
    public static int[] PreencherVetor(int[] Vetor)
    {
        Random r = new Random();

        for (int i = 0; i < Vetor.Length; i++)
        {
            Vetor[i] = r.Next(10, 31);
        }

        return Vetor;
    }

    public static void Adivinhar(int[] Vetor)
    {
        int tentativas = 0;
        int chute;
        bool adivinhou = false;

        while (adivinhou != true)
        {
            Console.Write("Tente Adivinhar um dos numeros sorteados entre 10 a 30: ");
            chute = int.Parse(Console.ReadLine());

            for (int i = 0; i < Vetor.Length; i++)
            {
                if (Vetor[i] == chute)
                {
                    Console.WriteLine("Parebens você adivinhou!");
                    adivinhou = true;
                    break;
                }
            }

            if (adivinhou == false)
            {
                Console.WriteLine("Que pena não foi dessa vez tente novamente...");
            }
            tentativas++;
        }

        Console.WriteLine($"Você demoru {tentativas} tentatvias até adivinhar um dos 5 numeros!");
    }
}