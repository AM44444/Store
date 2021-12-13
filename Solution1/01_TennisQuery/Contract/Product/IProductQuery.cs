using System.Collections.Generic;

namespace _01_TennisQuery.Contract.Product
{
    public interface IProductQuery
    {
        List<ProductQueryModel> GetLatestArrivals();
    }
}
