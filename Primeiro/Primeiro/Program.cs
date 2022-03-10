using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PESQUISA");
            Console.WriteLine("---------");
            int x = 0;
            int gasolina = 0, alcool = 0, diesel = 0;
            do
            {
                Console.WriteLine("Digite qual combustivel foi abastecido: ");
                Console.WriteLine("1 - Gasolina");
                Console.WriteLine("2 - Alcool");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Sair");
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.Write("Digite quantos clientes abasteceram Gasolina: ");
                        int gasLocal = int.Parse(Console.ReadLine());                       
                        gasolina = gasLocal + gasolina;
                        Console.WriteLine("Hoje " + gasLocal + " abasteceram com Gasolina.");
                        break;
                    case 2:
                        Console.Write("Digite quantos clientes abasteceram Alcool: ");
                        int alcLocal = int.Parse(Console.ReadLine());
                       alcool = alcLocal + alcool;
                        Console.WriteLine("Hoje " + alcLocal + " abasteceram com Alcool.");
                        break;
                    case 3:
                        Console.Write("Digite quantos clientes abasteceram Diesel: ");
                        int dieLocal = int.Parse(Console.ReadLine());
                        diesel = dieLocal + diesel;
                        Console.WriteLine("Hoje " + dieLocal + " abasteceram com Diesel.");
                        break;
                    case 4:
                        Console.WriteLine("Sair do programa!");
                        break;
                }
            } while (x != 4);
        }
    }
}

/*string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($" {produto1}, cujo o preço é {preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é {preco2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (3 casas decimais): {medida:F3}");
            Console.WriteLine("Agora com separação de ponto entre casas decimais" + medida.ToString("F2", CultureInfo.InvariantCulture));*/

/*string nome;
int quartos;
double preco;


Console.WriteLine("Digite seu nome completo: ");
nome = Console.ReadLine();

Console.WriteLine("Digite quantos quartos tem em sua casa: ");
quartos = int.Parse(Console.ReadLine());

Console.WriteLine("digite o preço da casa:");
preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite seu sobrenome, idade e aultura (na mesma linha): ");
string[] vetor = Console.ReadLine().Split(' ');
string sobreNome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

Console.WriteLine("Você digitou:");
Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(sobreNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));*/