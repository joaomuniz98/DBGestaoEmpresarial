using DBGestaoEmpresarial.Domain.Entities;
using System.ComponentModel.DataAnnotations;

public class Employe : Base
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    public string? Name { get; set; }

    public int IdCargo { get; set; }

    public float Salario { get; set; }

    public bool Ativo { get; set; }

    public Employe(string name, int idCargo, float salario, bool ativo)
    {
        Name = name;
        IdCargo = idCargo;
        Salario = salario;
        Ativo = ativo;
    }
}
