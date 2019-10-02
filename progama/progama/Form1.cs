using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Login efetuado com sucesso");
                tela2 tela = new tela2();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretas");
            }
        }
    }
}
