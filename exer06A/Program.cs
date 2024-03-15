//criar vetor
int[] vetor = new  int[100];
//criar o obj que vai gera o número randômico
Random aleatorio = new Random();

//preenchendo vetor com valores
for(int  i = 0; i < vetor.Length; i++)
  {
    vetor[i] = aleatorio.Next(100);

  }

//ordenação
bool troca = false;
do{
    troca = false;
    for(int i = 0; i < vetor.Length - 1; i++)
{
    if(vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
        troca = true;
    }
}
}while(troca == true);

Console.Write("\n");


//imprimindo vetor 
for(int  i = 0; i < vetor.Length; i++)
  {
    Console.Write(vetor[i] + " ");

  }

