using bootcamp_store_backend.Domain.Entities;

namespace bootcamp_store_backend.Domain.Persistence
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(long id);
        Category Insert(Category category);
        Category Update(Category category);
        void Delete(long id);
    }
}