using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    interface IclinicaService
    {
        Task Add(Clinica clinica);

        Task Update(Clinica clinica);

        Task Delete(Clinica clinica);

        Task<Clinica> GetBy(Guid id);

        Task<List<Clinica>> findAll();
    }
}
