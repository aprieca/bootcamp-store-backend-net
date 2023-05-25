using AutoMapper;
using bootcamp_store_backend.Domain.Persistence;

namespace bootcamp_store_backend.Application.Services;

public class GenericService <E,D>: IGenericService<D> 
where D : class
where E : class
{
    protected readonly IGenericRepository<E> _genericRepository;
    protected readonly IMapper _mapper;

    public GenericService(IGenericRepository<E> repository, IMapper mapper)
    {
        _genericRepository = repository;
        _mapper = mapper;
    }

    public virtual List<D> GetAll()
    {
        var entities = _genericRepository.GetAll();
        var dto = _mapper.Map<List<D>>(entities);
        return dto;
    }

    public virtual D Get(long id)
    {
        var entity = _genericRepository.GetById(id);
        return _mapper.Map<D>(entity);
    }

    public virtual D Insert(D dto)
    {
        E entity = _mapper.Map<E>(dto);
        entity = _genericRepository.Insert(entity);
        return _mapper.Map<D>(entity);
    }

    public virtual D Update(D dto)
    {
        E entity = _mapper.Map<E>(dto);
        entity = _genericRepository.Update(entity);
        return _mapper.Map<D>(entity);
    }

    public virtual void Delete(long id)
    {
        _genericRepository.Delete(id);
    }
}