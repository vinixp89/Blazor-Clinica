using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class ClinicaService :IclinicaService
    {
        private readonly AppDbContext dbContext;

        public ClinicaService(AppDbContext appDbContext)

        {

            dbContext = appDbContext;
        }

        public async Task Add(Clinica clinica)

        {
            await dbContext.AddAsync(clinica);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(Clinica clinica)

        {
            dbContext.Update(clinica);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Clinica clinica)

        {
            dbContext.Remove(clinica);
            await dbContext.SaveChangesAsync();
        }
        public async Task<Clinica> GetBy(Guid id)
        {
            var clinica = await dbContext.clinica.FirstOrDefaultAsync(c => c.Id == id);
            return clinica;
        }

        public async Task<List<Clinica>> findAll()
        {
            var clinicas = await dbContext.clinica.ToListAsync();
            return clinicas;
            
        }
    }
}

