﻿using System.Collections.Generic;
namespace src.Models;

public class Pessoa
{
    public Pessoa()
    {
        this.Nome = "template";
        this.Idade = 0;
        this.Contratos = new List<Contrato>();
        this.Ativado = true;
        
    }

    public Pessoa(string nome, int idade, string Cpf)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.CPF = Cpf;
        this.Contratos = new List<Contrato>();
        this.Ativado = true;
    }
    public int Id { get; set; }

    public string Nome { get; set; }

    public int Idade { get; set; }

    public string? CPF { get; set; }

    public bool Ativado { get; set; }

    public List<Contrato> Contratos { get; set; }

}
