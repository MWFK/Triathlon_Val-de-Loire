using MyFinance.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Service
{
    /// <summary>
    ///     Add any custom business logic (methods) here
    /// </summary>
    public interface IProductService : IService<Product>
    {
        // mettre les méthodes autres que CRUD


        IEnumerable<Product> GetProductsByCategory(string categoryName);
    }

}
