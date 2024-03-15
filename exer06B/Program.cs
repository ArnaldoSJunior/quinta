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

Array.Sort(vetor);



Console.Write("\n");


//imprimindo vetor 
for(int  i = 0; i < vetor.Length; i++)
  {
    Console.Write(vetor[i] + " ");

  }

