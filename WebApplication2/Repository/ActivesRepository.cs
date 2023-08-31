using Prova.ContextDB;
using Prova.Models;
using WebApplication2.Repository;

namespace Prova.Repository
{
    public class ActivesRepository : IActiveRepository
    {
        public readonly DBConnect _context;

        public ActivesRepository(DBConnect context)
        {
            _context = context;
        }

        public async Task<Active> Get(string Code)
        {
            return _context.Actives.Where(x => x.Code == Code).First();
        }

        public async Task<Order> Buy(Order oa)
        {
            if (Models.Type.Compra == oa.Type) {
                _context.Orders.Add(oa);
				await _context.SaveChangesAsync();
            }

            return oa;
        }

        public async Task<Order> Sell(Order oa)
        {
            oa.Type = Models.Type.Venda;
            _context.Orders.Add(oa);
            await _context.SaveChangesAsync();

            return oa;
        }
    }
}
