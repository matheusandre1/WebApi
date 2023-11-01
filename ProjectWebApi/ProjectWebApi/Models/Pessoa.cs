using System.Collections.Generic;

namespace ProjectWebApi.Models;

public class Pessoa
{
    
    public int Id { get; set; }

    public string Nome { get; set; }

    public int Idade { get; set; }

    public string? CPF { get; set; }

    public bool Ativado { get; set; }

    public List<Contrato> Contratos { get; set; }

    public Pessoa()
    {
        Nome = "template";
        Idade = 0;
        Contratos = new List<Contrato>();
        Ativado = true;

    }

    public Pessoa(string nome, int idade, string Cpf)
    {
        Nome = nome;
        Idade = idade;
        CPF = Cpf;
        Contratos = new List<Contrato>();
        Ativado = true;
    }

}
