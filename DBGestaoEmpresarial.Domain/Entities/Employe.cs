using DBGestaoEmpresarial.Domain.Entities;
using System.ComponentModel.DataAnnotations;

public class Employe : Base
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    public string? Name { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Selecione o cargo válido")]
    public int IdCargo { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Digite um salario maior que 0")]
    public float Salario { get; set; }

    public bool Ativo { get; set; }

    [Required(ErrorMessage = "O email é obrigatório")]
    public string Email { get; set; }

    public string Telefones { get; set; }

    public string Endereco { get; set; }

    public Guid idFuncionario { get; set; }


}
