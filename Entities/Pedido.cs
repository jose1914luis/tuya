using System;
using System.ComponentModel.DataAnnotations;

namespace TuyaTest
{
    public class Pedido{

        public int PedidoId { get; set; }
        
        [Required]
        public int FacturaId { get; set; }
        public Factura Factura {get; set;}
        
        [Required]
        public int Clienteid { get; set; }
        public Cliente Cliente {get; set;}
        public DateTime FechaEntrega { get; set; }
    }
}