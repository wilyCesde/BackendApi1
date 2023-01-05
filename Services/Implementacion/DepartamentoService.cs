using BackendApi.Models;
using BackendApi.Services.Contrato;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Services.Implementacion
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly DBEmpleadoContext _dbContext;

        public DepartamentoService(DBEmpleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Departamento>> GetList()
        {
            try
            {
                List<Departamento> lista = new List<Departamento>();
                lista = await _dbContext.Departamentos.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
