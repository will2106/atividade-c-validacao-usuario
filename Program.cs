



Console.WriteLine($"digite seu nome: ");
string nome = Console.ReadLine();


while (nome.Length == 0 )
{
    Console.WriteLine($"Digite seu nome! ");
    

}

Console.WriteLine($"ola {nome} como vai? ");





Console.WriteLine($"digite sua idade: (de 0 a 100 )");
int idade = int.Parse(Console.ReadLine());

while (idade >100 )
{
    Console.WriteLine($" digite um valor valido! ");
    

}



Console.WriteLine($"digite seu salario: ");
int salario = int.Parse(Console.ReadLine());


while (salario  == 0 )
{
    Console.WriteLine($" digite um valor valido! ");
    

}


Console.WriteLine($"digite seu estado civil: digite 's' para solteiro,digite 'c' para casado, digite 'v' para viuvo,digite 'd' para divorciado");
char estadoCivil = char.Parse(Console.ReadLine());

while ( estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil !='d' )
{

   Console.WriteLine($"digite um caractere valido! ");
   estadoCivil = char.Parse(Console.ReadLine());

   

}


Console.WriteLine($"{nome} tem {idade} anos de idade, ganha {salario} por mes! ");
