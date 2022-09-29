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
    internal class Cliente
    {
        private string nombre;
        private string telefono;
        private string direccion;
        private List<Producto> listadoProductos;
        private Farmacia farmacia;
        public Cliente() 
        {
            this.listadoProductos = new List<Producto>();
        }

        public Cliente( string nombre, string telefono, string direccion , Farmacia farmacia )
        {
            this.listadoProductos = new List<Producto>();
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.farmacia = farmacia;
        }

        public string getNombre()
        {
            return nombre;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public List<Producto> getListadoProductos()
        {
            return listadoProductos ;
        }
        public void setNombre(string nombre) 
        { 
            this.nombre = nombre; 
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public void setListadoProductos(List<Producto> listadoProductos)
        {
            this.listadoProductos = listadoProductos;
        }
        public void comprar(string codigoProducto)
        {
            List<Producto> listadoProductosStock = this.farmacia.getProductoStock();
            for (int i = 0; i < listadoProductosStock.Count; i++)
            {
                if (listadoProductosStock[i].getCodigo() == codigoProducto)
                {
                    listadoProductos.Add(listadoProductosStock[i]);
                    break;
                }
            }
        }
        public Producto consultarPrecio(string codigoProducto)
        {
            List<Producto> listadoProductosStock = this.farmacia.getProductoStock();
            for (int i = 0; i < listadoProductosStock.Count; i++)
            {
                if ( listadoProductosStock[i].getCodigo() == codigoProducto)
                {
                    return listadoProductosStock[i];
                }
            }
            return null;
        }
        public void devolucion(string codigoProducto)
        {
            for (int i = 0; i < listadoProductos.Count; i++)
            {
                if (listadoProductos[i].getCodigo() == codigoProducto)
                {
                    listadoProductos.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
