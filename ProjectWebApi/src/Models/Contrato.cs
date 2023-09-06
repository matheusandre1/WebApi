using src.Models;

public class Contrato
{
    public Contrato()
    {
        this.Datacriacao = DateTime.Now;
        this.Valor = 0;
        this.TokenId = "000000";
        this.Pago = false;

    }
    public Contrato(string tokenid,double valor )
    {
        this.Datacriacao = DateTime.Now;
        this.TokenId = tokenid;
        this.Valor = valor;
        this.Pago = false;
    }
    public DateTime Datacriacao { get; set; }

    public string TokenId { get; set; }

    public double Valor { get; set; }

    public  bool Pago  { get; set; }
}
