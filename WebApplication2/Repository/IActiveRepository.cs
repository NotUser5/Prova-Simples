using Prova.Models;

namespace WebApplication2.Repository
{
    public interface IActiveRepository
    {
        public Task<Active> Get(string Code);
        public Task<Order> Buy(Order oa);
        public Task<Order> Sell(Order oa);

    }
}
