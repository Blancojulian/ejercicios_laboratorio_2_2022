using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioC02_estanteria.Biblioteca
{
    class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            _codigoDeBarra = codigoDeBarra;
            _marca = marca;
            _precio = precio;
        }

        #region PROP
        public string Marca { get { return _marca; } }

        public float Precio { get { return _precio; } }
        #endregion

        #region METODOS

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"------------------");
            sb.AppendLine($"Producto");
            sb.AppendLine($"Codigo de barra: {p._codigoDeBarra}");
            sb.AppendLine($"Marca: {p.Marca}");
            sb.AppendLine($"Precio: {p.Precio}");
            sb.AppendLine($"------------------");


            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS

        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            return p1._marca == marca;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1._marca == marca);
        }

        #endregion
    }
}
