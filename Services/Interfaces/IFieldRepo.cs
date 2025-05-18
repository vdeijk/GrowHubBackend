using System.Collections.Generic;
using System.Threading.Tasks;
using Models.ViewModels;

namespace Services.Interfaces
{
    public interface IFieldRepo
    {
        Task<IEnumerable<FieldItem>> GetAllFields();
        Task<FieldItem> GetFieldById(Guid id);
        Task AddField(FieldItem plant);
        Task UpdateField(Guid id, FieldItem plant);
        Task DeleteField(Guid id);
    }
}