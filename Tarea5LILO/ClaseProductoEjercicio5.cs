using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5LILO
{
    class ClaseProductoEjercicio5
    {
        string nombre;
        double precio;
        int cantidad;

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public double pPrecio
        {
            set { precio = value; }
            get { return precio; }
        }

        public int pCantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }

        public ClaseProductoEjercicio5()
        {
            nombre = "";
            precio = cantidad = 0;
        }

        public ClaseProductoEjercicio5(string nom,double pre, int cant  )
        {
            nombre = nom;
            precio = pre;
            cantidad = cant;
        }
        public string toString()
        {
            return nombre + " " + precio + " " + calcularImporte();
        }

        public double calcularImporte()
        {
            return precio * cantidad;
        }
    }
}
