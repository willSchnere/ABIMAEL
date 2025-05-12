/*int numero;
int soma = 0;
int  contador = 1;
do
{
    Console.WriteLine("Numero: " + contador);
    contador++;
}
while (contador <= 12);
do
{
    Console.WriteLine("Digite um numero (0 para sair)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
    Console.WriteLine("Soma e :" + soma);
}
while (numero != 0);*/
int numero;
int soma = 0;

do
{
    Console.WriteLine("Digite um numero(numero negativo para sair)");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero >= 0)
    {
        soma += numero;
        Console.WriteLine("Soma e : " + soma);
    }
    else
    {
        Console.WriteLine("A soma total e : "+soma);
    }
}
while (numero > 0);

