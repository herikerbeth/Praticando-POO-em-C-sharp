using Desafios_de_Codigo.Models;

// 
string nome = Console.ReadLine();
int idade = Convert.ToInt32(Console.ReadLine());

Pessoa pessoa = new Pessoa(nome, idade);
Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
