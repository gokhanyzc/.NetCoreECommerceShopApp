using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        T GetOne(Expression<Func<T, bool>> filter); // bulduğu ilk kaydı geri alacak.
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //bütün kayıtları geri alacak.

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
