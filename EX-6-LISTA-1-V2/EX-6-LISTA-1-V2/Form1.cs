using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_6_LISTA_1_V2
{
    public partial class Form1 : Form
    {
        private Conversor conversor = new Conversor();
        public Form1()
        {
            InitializeComponent();
            txt_cotaçao.Text = conversor.getcotaçao().ToString();
            txt_dolar.Text = conversor.getdolar().ToString();
            txt_real.Text = conversor.getReal().ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            conversor.setCotacao(double.Parse(txt_cotaçao.Text));
            conversor.setDolar(double.Parse(txt_dolar.Text));
            conversor.calcularReal();
            txt_real.Text = conversor.getReal().ToString();
        }
    }
}
