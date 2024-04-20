using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppValidaCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = mtbCPF;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnValida_Click(object sender, EventArgs e)
        {
            var cpf = ValidaCPF.IsCpf(mtbCPF.Text);
            if (cpf == true)
            {
                MessageBox.Show("CPF Válido!");
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }
        }
    }
}
