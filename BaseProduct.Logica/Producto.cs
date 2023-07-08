using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProduct.Logica
{
    public class Producto
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }

        public decimal CalcularCostoTotal()
        {
            return Precio * CantidadDisponible;
        }

        public void ActualizarCantidad(int cantidadComprada)
        {
            CantidadDisponible -= cantidadComprada;
        }
    }
}

