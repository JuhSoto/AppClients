namespace Cadastro;


public class Cliente()
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateOnly DtNascimento { get; set; }
    public DateTime DtCadastrado{ get; set; }
    public decimal Desconto { get; set; }

}
