public class Atividade2
{
    public static void PreencherVetor(int[] vetor)
    {
        Random r = new Random();

        for(int i = 0; i < vetor.Length; i++)
        {
            vetor[i]= r.Next(1,101);
        }
    }

    public static int MenorElemento(int[] vetor)
    {
        int menor= vetor[0];
        for(int i = 0; i < vetor.Length; i++)
        {
            if(vetor[i] < menor)
                menor = i;
        }

        return menor;
    }
}