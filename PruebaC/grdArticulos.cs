using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PruebaC
{
    internal class grdArticulos
    {

             public int id_producto { get; set; }

            public int id_tipo_producto { get; set; }

        public string nombre_producto { get; set; }

        public float precio_unitario_producto { get; set; }

        public string Sku { get; set; }

        public string codigo_barras { get; set; }

        public float peso_kg { get; set; }

        public string detalles_producto { get; set; }

        public grdArticulos(int Id_producto, int Id_tipo_producto, string Nombre_producto, float Precio_unitario_producto, string SKU, string Codigo_barras, float Peso_kg, string Detalles_producto)
        {
            this.id_producto = Id_producto;
            this.id_tipo_producto = Id_tipo_producto;
            this.nombre_producto = Nombre_producto;
            this.precio_unitario_producto = Precio_unitario_producto;
            this.Sku = SKU;
            this.codigo_barras = Codigo_barras;
            this.peso_kg = Peso_kg;
            this.detalles_producto = Detalles_producto;

        }
   

    }
}
