namespace ProjectWebApi.Models;

public class Contrato
{
    public Contrato()
    {
        DataCriacao = DateTime.Now;
        TokenID = "000000";
        Valor = 0;
        Pago = false;
    }

    public Contrato(string tokenid, double valor)
    {
        DataCriacao = DateTime.Now;
        TokenID = tokenid;
        Valor = valor;
        Pago = false;

    }
    public int Id { get; set; }
    public DateTime DataCriacao { get; set; }

    public string TokenID { get; set; }

    public double Valor { get; set; }

    public bool Pago { get; set; }
}