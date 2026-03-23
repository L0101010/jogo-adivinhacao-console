Console.WriteLine("Olá, vamos jogar um jogo, voce vai tentar descobrir o numero que estou pensando entre 1 e 20...");

Random num1 = new Random();
int valor1 = num1.Next(1, 21);
 
Console.WriteLine("tente adivinhar!");
int resposta = Convert.ToInt32(Console.ReadLine());

int tent = 1;

while (resposta != valor1)
{
    if (resposta > valor1)
    {
        Console.WriteLine("O numero que estou pensando é menor do que isso! tente novamente.");
        resposta = Convert.ToInt32(Console.ReadLine());
        tent ++ ;
    }

    else if (resposta < valor1)
    {
        Console.WriteLine("O numero que estou pensando é maior do que isso! tente novamente.");
        resposta = Convert.ToInt32(Console.ReadLine());
        tent++;
    }

    else
    {
        Console.WriteLine("Numero invalido tente de novo");
        resposta = Convert.ToInt32(Console.ReadLine());
        tent++;
    }
}

if  (resposta == valor1)
{     
    Console.WriteLine($"Parabens voce acertou o numero que eu estava pensando! e voce precisou de {tent} tentativas para isso!"); 
}