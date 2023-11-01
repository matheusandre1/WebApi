using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using ProjectWebApi.Models;

namespace ProjectWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    [HttpGet]
    public Pessoa Get()
    {
        Pessoa pessoa = new Pessoa("Matheus Andre", 24, "00000000000");
        Contrato contrato = new Contrato("abc123", 50.65);
        pessoa.Contratos.Add(contrato);
        return pessoa;
    }

    [HttpPost]
    public Pessoa Post([FromBody] Pessoa pessoa)
    {
        return pessoa;
    }

    [HttpPut("{id}")]

    public string Uptade([FromRoute] int id, [FromBody] Pessoa pessoa)
    {
        Console.WriteLine(id);
        Console.WriteLine(pessoa);

        return $"Dados do Id {id} Atualcizado!";
    }

    [HttpDelete("{id}")]
    public string Delete([FromRoute] int id)
    {
        return $"Deletado pessoa de {id}";

    }
}