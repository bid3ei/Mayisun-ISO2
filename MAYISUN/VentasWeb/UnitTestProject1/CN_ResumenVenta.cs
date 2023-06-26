using CapaDatos;
using CapaModelo;
using System.Collections.Generic;

namespace UnitTestProject1
{
    public class CN_ResumenVenta
    {
        private CD_ResumenVenta objCapaDato = new CD_ResumenVenta();

        public List<ResumenVentas> ObtenerVenta()
        {
            return objCapaDato.ObtenerVenta();
        }
    }
}
