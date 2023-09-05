using Microsoft.AspNetCore.Mvc;
using src.Models;
namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    [HttpGet]
    public Pessoa Get()
    {
        Pessoa pessoa = new Pessoa("Matheus", 24, "12345678900");
        Contrato novoContrato = new Contrato("abc123", 53.60);
        
        pessoa.Contratos.Add(novoContrato);
        return pessoa; ;
    }

    [HttpPost]
    public Pessoa Post(Pessoa pessoa )
    {
        return pessoa;
    }

    [HttpPut]

    public string Update(Pessoa pessoa)
    {
        
    }
}