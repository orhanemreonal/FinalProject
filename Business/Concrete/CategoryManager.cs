using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public IResult Add(Category category)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result = _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(result);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            var result = _categoryDal.Get(c => c.CategoryId == categoryId);
            return new SuccessDataResult<Category>(result);
        }

        public IResult Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
