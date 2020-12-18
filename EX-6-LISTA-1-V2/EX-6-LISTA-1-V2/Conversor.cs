using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6_LISTA_1_V2
{
    class Conversor
    {
        #region atributos
        private double cotaçao;
        private double dolar;
        private double real;
        #endregion
        #region construtor
        public Conversor() 
        {
            cotaçao = 0;
            dolar = 0;
            calcularReal();
        }
        #endregion
        #region set e gets
        public void setCotacao(double cotaçao)
        {
            this.cotaçao = cotaçao;
        }
        public void setDolar(double dolar)
        {
            this.dolar = dolar;
        }
        public Double getcotaçao()
        {
            return cotaçao;
        }
        public Double getdolar()
        {
            return dolar;
        }
        public Double getReal()
        {
            return real;
        }
        #endregion
        #region metodos
        public void calcularReal() 
        {
            real = dolar * cotaçao;
        }
        #endregion

    }
}
