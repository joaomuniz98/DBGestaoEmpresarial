using DBGestaoEmpresarial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGestaoEmpresarial.Infrastructure.Abstraction
{
    public interface IEmployesRepository
    {
        Task<IEnumerable<Employe>> GetAllEmployes();
        Task<Employe?> GetEmploye(int id);
        Task<Employe> AddEmploye(Employe emp);
        Task<bool> DesativarEmploye(int id);
        Task AtualizarEmploye(Employe emp);
    }
}
