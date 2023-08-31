using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prova.Models
{
	public class OrderVM
	{
		public int Id { get; set; }
		public string CodeId { get; set; }
		public Type Type { get; set; }
		public int Qty { get; set; }
		public decimal Value { get; set; }
		public DateTime Data { get; set; }
	}
}
