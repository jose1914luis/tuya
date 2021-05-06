using System;
using System.Collections.Generic;

namespace TuyaTest
{
    public class Factura{

        public int FacturaId { get; set; }
        public int  ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaFactura { get; set; }
        public int TotalFactura { get; set; }
        public List<DescripcionFactura> DescripcionFacturas { get; } = new List<DescripcionFactura>();
    }
}