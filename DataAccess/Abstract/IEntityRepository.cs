using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    // Generic Constraint - Generic Kısıt
    // class : Referans tip olabilir demek.(value type giremezsin).
    // Tüm Entitylerimiz IEntity Interface'ini implemente ettiği için zorunlu hale getirdik.
    // new() : new'lenebilir olmalı. Interface new'lenemez.
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        // Generic Repository Design Pattern
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
