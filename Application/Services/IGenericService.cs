
namespace bootcamp_store_backend.Application.Services
{
    public interface IGenericService<D> where D : class
    {
        List<D> GetAll();
        D Get(long id);
        D Insert(D categoryDto);
        D Update(D categoryDto);
        void Delete(long id);
    }
}

