using Shop.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Car.DAL
{
    public class BaseBAL<T> where T: class
    {
        CarContext context = new CarContext();

        /// <summary>
        /// IQueryable延迟加载集合，调用时才会去加载至内存
        /// List查询后会立即加载至内存中
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetEntitys(Expression<Func<T,bool>> lambdaWhere)
        {
            //context.UserInfoes.Where(lambdaWhere);
            return context.Set<T>().Where(lambdaWhere);
        }


        public int Add(T entity)
        {
            context.Set<T>().Add(entity);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            //通过ID查询
            T entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }


        public int Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;  //标志位修改
            return context.SaveChanges();
        }
    }
}
