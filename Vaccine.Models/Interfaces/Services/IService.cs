namespace Vaccine.Models.Interfaces.Services
{
    public interface IService<TModel, TModelDto, TModelAddDto, TModelUpdateDto, TId>
        where TModel : IEntity<TId>
        where TModelDto : IEntity<TId>
        where TModelAddDto : IEntity<TId>
        where TModelUpdateDto : IEntity<TId>
    {
        TModelDto Add(TModelAddDto obj);
        IEnumerable<TModelDto> GetAll();
        TModelUpdateDto GetById(TId id);
        TModelDto Update(TId id, TModelUpdateDto obj);
        int GetCountEntity();
        TModelDto Remove(TId id);
    }
}
