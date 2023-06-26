using CapaDatos;
using CapaModelo;

namespace UnitTestProject1
{
    public class CN_DashBoard
    {
        private CD_DashBoard objCapaDato = new CD_DashBoard();
        public DashBoard VerDashBord()
        {
            return objCapaDato.VerDashBord();
        }
    }
}
