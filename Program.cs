public class Program
{
    public static void Main()
    {
        int tamanho;
        int[] VetorAtividade1 = new int[5];
        Atividade1.PreencherVetor(VetorAtividade1);

        Atividade1.Adivinhar(VetorAtividade1);

        Console.WriteLine("Insira o tamanho do vetor desejado: ");
        tamanho = int.Parse(Console.ReadLine());

        int[] VetorAtividade2 = new int[tamanho];

        Atividade2.PreencherVetor(VetorAtividade2);

        for(int i = 0; i < VetorAtividade2.Length; i++)
        {
            Console.Write($"{VetorAtividade2[i]}, ");
        }

        Console.WriteLine();

        Console.WriteLine($"O menor numero desse vetor está na posição {Atividade2.MenorElemento(VetorAtividade2)} do vetor!");
    }
}