using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGeneral
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        public Lata(string codigo, double volumen)
        {
            this._codigo = codigo;
            if (codigo.Contains("CO"))
            {
                this._nombre = "Coca Cola";
                this._precio = 35;
            }
            else if (codigo.Contains("SP"))
            {
                this._nombre = "Sprite";
                this._precio = 33;
            }
            else if (codigo.Contains("FA"))
            {
                this._nombre = "Fanta";
                this._precio = 50;
            }
            if (codigo.Contains("1"))
            {
                this._sabor = "Regular";
            }
            else if (codigo.Contains("2"))
            {
                this._sabor = "Zero";
                this._precio += 10;
            }
            this._volumen = volumen;
        }
        public string Codigo
        {
            get
            {
                return this._codigo;
            }
        }
        public string Nombre
        {
            set
            {
                this._nombre = value;
            }
            get
            {
                return this._nombre;
            }
        }
        public string Sabor
        {
            set
            {
                this._sabor = value;
            }
            get
            {
                return this._sabor;
            }
        }
        public double Precio
        {
            set
            {
                this._precio = value;
            }
            get
            {
                return this._precio;
            }
        }
        public double Volumen
        {
            get
            {
                return this._volumen;
            }
        }
        public double GetPrecioPorLitro()
        {
            return this._precio * this._volumen;
        }
        public override string ToString()
        {
            return Codigo + " - " + Nombre + " " + Sabor;
        }
    }
}
