string comando = "";
int contador2 = 1;
int contador = 1;
Console.WriteLine("Exemplo 1");
Console.WriteLine("Contagem de 20 até 1");

for (int i = 20; i > 1; i-=2)
{
    Console.WriteLine("Numero tem o valor de =: " + i);
}

Console.WriteLine("Contagem finalizado.");

while (contador <= 5)
{
    Console.WriteLine("Numero: " + contador);
    contador++;
}
Console.WriteLine("Contagem finalizada");
Console.WriteLine("Exemplo 3: Testando entrada de dados");

while (comando.ToUpper() != "SAIR")
{
    Console.WriteLine("Digite um comando qualquer (ou digite 'sair' para encerrar):");
    comando = Console.ReadLine();
    Console.WriteLine("Você digitou " + comando); 
    Console.WriteLine("Em toUpper = " + comando.ToUpper());
}
Console.WriteLine("Programa encerrado");
//while com string e com toUpper para reconhecer maiusculo e minusculo//

