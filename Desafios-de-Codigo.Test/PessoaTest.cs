using Desafios_de_Codigo.Models;

namespace Desafios_de_Codigo.Test;

public class PessoaTest
{
    [Theory]
    [InlineData("Ana", 17, "Nome: Ana, Idade: 17")]
    [InlineData("Paulo", 44, "Nome: Paulo, Idade: 44")]
    [InlineData("Maria", 32, "Nome: Maria, Idade: 32")]
    public void Deve_Retornar_Pessoa_Com_Nome_E_Idade(string nome, int idade, string expected)
    {
        // arrange
        Pessoa pessoa = new Pessoa(nome, idade);
        // act
        string result = $"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}";
        // assert
        Assert.Equal(expected, result);
    }
}