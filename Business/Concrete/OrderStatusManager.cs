using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderStatusManager : IOrderStatusService
    {
        IOrderStatusDal _orderStatusDal;

        public OrderStatusManager(IOrderStatusDal orderStatusDal)
        {
            _orderStatusDal = orderStatusDal;
        }

        public IResult Add(OrderStatus order)
        {
            _orderStatusDal.Add(order);
            return new SuccessResult();
        }

        public IResult Delete(OrderStatus order)
        {
            _orderStatusDal.Delete(order);
            return new SuccessResult();
        }

        public IDataResult<List<OrderStatus>> GetAll()
        {
            return new SuccessDataResult<List<OrderStatus>>(_orderStatusDal.GetAll());
        }

        public IResult Update(OrderStatus order)
        {
            _orderStatusDal.Update(order);
            return new SuccessResult();
        }
    }
}
