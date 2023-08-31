using Microsoft.AspNetCore.Mvc;
using Prova.Models;
using WebApplication2.Repository;

namespace Prova.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivesController : ControllerBase
    {
        private readonly IActiveRepository _activeRepository;

        public ActivesController(IActiveRepository activeRepository)
        {
            _activeRepository = activeRepository;
        }

        [HttpGet("GetActives")]
        public async Task<ActionResult<Active>> GetActives(string Code)
        {
            return await _activeRepository.Get(Code);
        }

        [HttpPost("BuyActives")]
        public async Task<ActionResult<Order>> BuyActives(OrderVM order)
        {
            //todo: map method for VM's
            var newOrder = new Order()
            {
                CodeId = order.CodeId,
                Data = order.Data,
                Id = order.Id,
                Qty = order.Qty,
                Type = order.Type,
                Value = order.Value
            };

            return await _activeRepository.Buy(newOrder);
        }

        [HttpPost("SellActives")]
        public async Task<ActionResult<Order>> SellActives(OrderVM order)
        {
			//todo: map method for VM'svar newOrder = new Order()
			var newOrder = new Order()
			{
				CodeId = order.CodeId,
                Data = order.Data,
                Id = order.Id,
                Qty = order.Qty,
                Type = order.Type,
                Value = order.Value

			};
			return await _activeRepository.Sell(newOrder);
        }
    }
}