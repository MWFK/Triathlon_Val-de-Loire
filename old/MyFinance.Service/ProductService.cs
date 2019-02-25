using MyFinance.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using MyFinance.Data.Repositories;
using MyFinance.Data;
using Service.Pattern;

namespace MyFinance.Service
{
    public class ProductService : Service<Product>, IProductService
    {
       
       
        private static IDatabaseFactory dbf =  new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        //public ProductService(IUnitOfWork ut)
        //    : base(ut)
        //{
        //    this.ut = ut;

        //}
        public ProductService()
           : base(ut)
        {
           
        }
        /*public IEnumerable<Product> GetProductsByCategory(string categoryName)
        {
            return ut.getRepository<Product>().GetMany(x => x.Category.Name == categoryName);
        }*/

        public IEnumerable<Product> GetProductsByCategory(string categoryName)
        {
            return GetMany(x => x.Category.Name == categoryName);
        }
    }

}
