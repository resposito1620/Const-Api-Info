using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneral
{
    public class ExtraccionObtenida
    {
        private Lata _lata;
        private double _vuelto;
        public ExtraccionObtenida(Lata lata, double vuelto)
        {
            this._lata = lata;
            this._vuelto = vuelto;
        }
        public Lata Lata
        {
            set
            {
                this._lata = value;
            }
            get
            {
                return this._lata;
            }
        }
        public double Vuelto
        {
            set
            {
                this._vuelto = value;
            }
            get
            {
                return this._vuelto;
            }
        }
    }
}
