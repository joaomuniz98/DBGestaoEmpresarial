using DBGestaoEmpresarial.Domain.Entities;
using DBGestaoEmpresarial.Infrastructure.Abstraction;
using DBGestaoEmpresarial.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGestaoEmpresarial.Infrastructure.Repositories
{
    public class EmployeRepository : IEmployesRepository
    {
        public readonly MyContext _context;
        public EmployeRepository(MyContext context) {

            _context = context;
        }

        public async Task<Employe> AddEmploye(Employe emp)
        {
            if(_context is not null && emp is not null && _context.Employes is not null)
            {

                emp.Ativo = true;
                emp.DateCreated = DateTime.Now;
                _context.Employes.Add(emp);
                await  _context.SaveChangesAsync();

                return emp;
            }
            else
            {
                return new Employe("",0,0,true);
            }
        }

        public async Task AtualizarEmploye(Employe emp)
        {
            if (_context is not null && emp is not null && _context.Employes is not null)
            {
                var employe = _context.Employes.FirstOrDefault(x => x.Id == emp.Id);

                if (employe != null)
                {
                    _context.Entry(emp).CurrentValues.SetValues(employe);   
                    await _context.SaveChangesAsync();  
                }
                else
                {
                    throw new Exception("Employe not found.");
                }
            
            }
            else
            {
                throw new InvalidOperationException("Invalid data when processing input.");
            }
        }

        public async Task<bool> DesativarEmploye(int id)
        {
            var employe = await GetEmploye(id);

            if (_context is not null && employe is not null && _context.Employes is not null)
            {
                _context.Employes.Remove(employe);
                await _context.SaveChangesAsync(); // Chamada assíncrona
                return true;
            }
            else
            {
                return false; // Retorna false se o empregado não foi encontrado
            }
        }


        public async Task<IEnumerable<Employe>> GetAllEmployes()
        {
             return await _context.Employes.ToListAsync();
        }

        public async Task<Employe?> GetEmploye(int id)
        {
            var employeFound = await _context.Employes.FirstOrDefaultAsync(x => x.Id == id);
          
            return employeFound;
        }
    }
}
