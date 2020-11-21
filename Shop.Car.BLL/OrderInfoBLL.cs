using Shop.Car.DAL;
using Shop.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Car.BLL
{
    public class OrderInfoBLL
    {
        OrderInfoDAL OrderInfoDAL = new OrderInfoDAL();
        public List<OrderInfo> GetAllModelList(Expression<Func<OrderInfo, bool>> lambdaWhere)
        {
            return OrderInfoDAL.GetEntitys(lambdaWhere).ToList();
        }

        public bool DoworkOrder(int id)
        {
            OrderInfo order = OrderInfoDAL.GetEntitys(o => o.OId == id).FirstOrDefault();
            order.OState = 1;
            return OrderInfoDAL.Update(order) > 0?true : false;
        }
    }
}
