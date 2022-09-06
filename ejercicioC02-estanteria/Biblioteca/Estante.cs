using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioC02_estanteria.Biblioteca
{
    class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante) : this(capacidad)
        {
            _ubicacionEstante = ubicacionEstante;
        }

        #region METODOS
        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public static void MostrarEstante(Estante e)
        {
            Producto[] arr = e.GetProductos();

            foreach (Producto p in arr)
            {
                Producto.MostrarProducto(p);
            }
        }
        #endregion

        #region SOBRECARGAS

        public static bool operator ==(Estante e, Producto p)
        {
            bool b = false;

            Producto[] arr = e.GetProductos();

            foreach (Producto producto in arr)
            {
                if (producto.Equals(p))
                {
                    b = true;
                    break;
                }
            }

            return b;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool b = true;

            Producto[] arr = e.GetProductos();

            foreach (Producto producto in arr)
            {
                if (producto.Equals(p))
                {
                    b = false;
                    break;
                }
            }

            return b;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool b = false;

            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] is null)
                {
                    e._productos[i] = p;
                    b = true;
                    break;

                }
            }

            return b;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e == p)
                {
                    e._productos[i] = null;
                    break;
                }
            }
            return e;

        }

        #endregion

    }
}
