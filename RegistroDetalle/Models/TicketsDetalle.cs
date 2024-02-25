using System.ComponentModel.DataAnnotations;

namespace RegistroDetalle.Models
{
	public class TicketsDetalle
	{
		[Key]
		public int DetalleId { get; set; }
		public int TicketId { get; set; }

		[Required(ErrorMessage = "Campo obligatorio")]
		[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta números")]
		public string? Emisor { get; set; }

		[Required(ErrorMessage = "Campo Obligatorio")]
		public string? Mensaje { get; set; }
	}
}
