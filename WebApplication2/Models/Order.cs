using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prova.Models
{
    public class Order
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

		public Active? Active { get; set; }

		[ForeignKey("Code")]
		public string CodeId { get; set; }

        public Type Type { get; set; }

        public int Qty { get; set;}

        //[Column(TypeName ="decimal(18,2)")]
        public decimal Value { get; set;}

        public DateTime Data { get; set;}
    }
}
