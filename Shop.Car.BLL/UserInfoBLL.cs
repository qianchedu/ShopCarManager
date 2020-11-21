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

    public class UserInfoBLL
    {

        UserInfoDAL userInfoDAL = new UserInfoDAL();

        /// <summary>
        /// 检查用户登录
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public UserInfo CheckLogin(UserInfo userInfo)
        {
            //FirstOrDefault 如果未查询到返回null
            //First如果未查询到抛出异常
            return userInfoDAL.GetEntitys(u=>u.UName == userInfo.UName && u.UPwd == userInfo.UPwd).FirstOrDefault();
        }


        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        public object GetAllModelList(Expression<Func<UserInfo,bool>> lambdaWhere)
        {
            return userInfoDAL.GetEntitys(lambdaWhere);
        }
    }
}
