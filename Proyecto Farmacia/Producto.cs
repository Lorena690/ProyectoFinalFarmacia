using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// AUTOR: LORENA SÁNCHEZ FERNÁNDEZ//
// CÓDIGO: 1116247763//
namespace Proyecto_Farmacia
{
    internal class Producto
    {
        private string nombreDelProducto;
        private double precio;
        private string laboratorio;
        private string presentacion;
        private string cantidad;
        private string composicion;
        private string codigo;

        public Producto(){
        }

        public Producto( string nombreDelProducto , double precio, string laboratorio , string presentacion, string cantidad , string composicion , string codigo )
        {
            this.nombreDelProducto = nombreDelProducto;
            this.precio = precio;
            this.laboratorio = laboratorio;
            this.presentacion = presentacion; 
            this.cantidad = cantidad;  
            this.composicion = composicion;
            this.codigo = codigo;
        }

        public string getNombreDelProducto()
        {
            return nombreDelProducto;
        }

        public double getPrecio()
        {
            return precio;
        }

        public string getLaboratorio()
        {
            return laboratorio;
        }

        public string getPresentacion()
        {
            return presentacion;
        }

        public string getCantidad()
        {
            return cantidad;
        }

        public string getComposicion()
        {
            return composicion;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public void setNombreDelProducto(string nombreDelProducto)
        {
            this.nombreDelProducto = nombreDelProducto;
        }
        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
        public void setLaboratorio(string laboratorio)
        {
            this.laboratorio = laboratorio;
        }
        public void setPresentacion(string presentacion)
        {
            this.presentacion = presentacion;
        }
        public void setCantidad(string cantidad)
        {
            this.cantidad = cantidad;
        }
        public void setComposicion(string composicion)
        {
            this.composicion = composicion;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public override string ToString()
        {
            return "Nombre del  Producto " + nombreDelProducto + "\n\r " +
                "precio " + precio + "\n\r " +
                "laboratorio " + laboratorio + "\n\r " +
                "Presentacion " + presentacion + "\n\r " +
                "cantidad" + cantidad + "\n\r " +
                "composicion " + composicion + "\n\r " +
                "codigo " + codigo + "\n\r "; 
        }
    }
}
