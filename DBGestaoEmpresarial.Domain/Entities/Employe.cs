using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGestaoEmpresarial.Domain.Entities
{
    public class Employe : Base
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";
         
        public int IdCargo { get; set; } 

        public float Salario {  get; set; }

        public bool Ativo {  get; set; }

        public Employe(string name, int idCargo, float salario, bool ativo)
        {
            Name = name;
            IdCargo = idCargo;
            Salario = salario;
            Ativo = ativo;

        }

        public Employe()
        {
        }
    }
}
