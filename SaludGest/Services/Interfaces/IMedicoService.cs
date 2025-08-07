using SaludGest.DTOs.Medico;

namespace SaludGest.Services.Interfaces
{
    public interface IMedicoService : IGenericService<MedicoCreateDTO, MedicoReadDTO, MedicoCreateDTO>
    {
    }
}
