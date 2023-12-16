using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
        Category Get(Expression<Func<Category, bool>> filter);
        void Add(Category entity);
        void Update(Category entity);
        void Delete(Category entity);

    }
}
