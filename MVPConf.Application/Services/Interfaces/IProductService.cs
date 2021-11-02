using MVPConf.Application.Models;
using System.Collections.Generic;

namespace MVPConf.Application.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
