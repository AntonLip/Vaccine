using AutoMapper;
using Vaccine.Models.Interfaces;
using Vaccine.Models.Interfaces.Repository;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Services
{
    public abstract class BaseService<TModel, TModelDto, TModelAddDto, TModelUpdateDto> : IService<TModel, TModelDto, TModelAddDto, TModelUpdateDto, Guid>
            where TModelDto : class, IEntity<Guid>
            where TModel : class, IEntity<Guid>
            where TModelAddDto : IEntity<Guid>
            where TModelUpdateDto : IEntity<Guid>
    {
        protected readonly IRepository<TModel, Guid> _repository;
        protected readonly IMapper _mapper;
        public BaseService(IRepository<TModel, Guid> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual TModelDto Add(TModelAddDto modelDto)
        {
            if (modelDto is null)
                throw new ArgumentNullException();

            var model = _mapper.Map<TModel>(modelDto);

            _repository.Add(model);
            return _mapper.Map<TModelDto>(model);
        }

        public virtual IEnumerable<TModelDto> GetAll()
        {
            var listModelDto = _repository.GetAll();
            return listModelDto is null ? throw new ArgumentException() : _mapper.Map<List<TModelDto>>(listModelDto);
        }

        public int GetCountEntity()
        {
            return _repository.GetCount();
        }

        public virtual TModelUpdateDto GetById(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentNullException();

            var modelDto = _repository.GetById(id);
            return modelDto is null ? throw new ArgumentException() : _mapper.Map<TModelUpdateDto>(modelDto);
        }

        public virtual TModelDto Remove(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentNullException();

            var model = _repository.GetById(id);
            if (model is null)
                throw new ArgumentException();
            _repository.Remove(model);
            return _mapper.Map<TModelDto>(model);
        }

        public virtual TModelDto Update(Guid id, TModelUpdateDto modelDto)
        {
            if (id != modelDto.Id)
                throw new ArgumentNullException();

            var model = _mapper.Map<TModel>(modelDto);
            _repository.Update(model);
            return _mapper.Map<TModelDto>(model);
        }
    }
}
