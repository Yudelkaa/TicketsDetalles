using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RegistroDetalle.Models
{
	public class Tickets
	{
		[Key]
		public int TicketId { get; set; }

		public int ClienteId { get; set; }

		[Required(ErrorMessage = "Campo Obligatorio")]
		public DateTime Fecha { get; set; } = DateTime.Now;

		[Required(ErrorMessage = "Campo Obligatorio")]
		public string? Asunto { get; set; }

		[Required(ErrorMessage = "Campo Obligatorio")]
		public string? Descripcion { get; set; }

		[Required(ErrorMessage = "Campo Obligatorio")]
		[StringLength(30, ErrorMessage = "No puede exceder los 30 Caracteres")]
		public string? SolicitadoPor { get; set; }

		[ForeignKey("TicketId")]
		public ICollection<TicketsDetalle> TicketsDetalle { get; set; } = new List<TicketsDetalle>();

	}
}
