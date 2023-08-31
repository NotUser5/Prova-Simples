using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prova.Models
{
    public class Active
    {
        [Key]
        public string Code { get; set; }

        public decimal Price { get; set; }

		public ICollection<Order>? Orders { get; set; }
	}
}
