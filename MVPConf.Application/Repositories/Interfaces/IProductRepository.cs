using MVPConf.Application.Models;
using System.Collections.Generic;

namespace MVPConf.Application.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
