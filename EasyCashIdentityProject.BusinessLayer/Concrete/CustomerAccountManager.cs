using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void Add(CustomerAccount entity)
        {
            _customerAccountDal.Add(entity);
        }

        public void Delete(CustomerAccount entity)
        {
            _customerAccountDal.Delete(entity);
        }

        public List<CustomerAccount> GetAll()
        {
            return _customerAccountDal.GetAll();
        }

        public CustomerAccount GetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public void Update(CustomerAccount entity)
        {
            _customerAccountDal.Update(entity);
        }
    }
}
