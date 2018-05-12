using Business.Logic;
using Common.Autofac;
using Common.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormWCF
{
    public partial class Form1 : Form
    {
        private ICalculadoraBusiness calculadoraBusiness;

        public Form1()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            this.calculadoraBusiness = BusinessConfiguration.GetCalculadoraBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ReferenciaWeb.Service1Client svc = new ReferenciaWeb.Service1Client("Tcp");
            //MessageBox.Show(svc.Suma(4, 2).ToString());
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int number1 = this.textBoxNum1.Text != "" ? Convert.ToInt32(this.textBoxNum1.Text) : 0;
            int number2 = this.textBoxNum2.Text != "" ? Convert.ToInt32(this.textBoxNum2.Text) : 0;
            this.lblSolucion.Text = this.calculadoraBusiness.Sumar(number1, number2);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int number1 = this.textBoxNum1.Text != "" ? Convert.ToInt32(this.textBoxNum1.Text) : 0;
            int number2 = this.textBoxNum2.Text != "" ? Convert.ToInt32(this.textBoxNum2.Text) : 0;
            this.lblSolucion.Text = this.calculadoraBusiness.Restar(number1, number2);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int number1 = this.textBoxNum1.Text != "" ? Convert.ToInt32(this.textBoxNum1.Text) : 0;
            int number2 = this.textBoxNum2.Text != "" ? Convert.ToInt32(this.textBoxNum2.Text) : 0;
            this.lblSolucion.Text = this.calculadoraBusiness.Multiplicar(number1, number2);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int number1 = this.textBoxNum1.Text != "" ? Convert.ToInt32(this.textBoxNum1.Text) : 0;
            int number2 = this.textBoxNum2.Text != "" ? Convert.ToInt32(this.textBoxNum2.Text) : 0;
            this.lblSolucion.Text = this.calculadoraBusiness.Dividir(number1, number2);
        }

        private void radioButtonHttp_CheckedChanged(object sender, EventArgs e)
        {
            Configuracion.SetValueFromAppConfig("TypeConnectionService", "Http");
        }

        private void radioButtonTcp_CheckedChanged(object sender, EventArgs e)
        {
            Configuracion.SetValueFromAppConfig("TypeConnectionService", "Tcp");
        }
    }
}
