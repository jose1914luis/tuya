using System;

namespace TuyaTest
{
    public class Pedido{

        public int PedidoId { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura {get; set;}
        public int Clienteid { get; set; }
        public Cliente Cliente {get; set;}
        public DateTime FechaEntrega { get; set; }
    }
}