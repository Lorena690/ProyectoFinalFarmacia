using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
// AUTOR: LORENA SÁNCHEZ FERNÁNDEZ//
// CÓDIGO: 1116247763//
namespace Proyecto_Farmacia
{
    internal class Farmacia
    {
        private List<Producto> productoStock;

        public Farmacia() 
        {
            productoStock = new List<Producto>();
        }

        public List<Producto> getProductoStock()
        {
            return productoStock;
        }

        public void setProductoStock(List<Producto> productoStock)
        {
            this.productoStock = productoStock;
        }

        public void agregarProducto(Producto producto)
        {
            productoStock.Add(producto);
        }
    }
}
