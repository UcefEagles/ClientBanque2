using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBanque2
{
    public partial class Form1 : Form
    {
        private ServiceReference1.BanqueWsClient stub;
        
        public Form1()
        {
            InitializeComponent();
            stub = new ServiceReference1.BanqueWsClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mt=Double.Parse(textBox1MT.Text);
            double res =stub.ConversionEuroToDh(mt);
            textBox1Res.Text = res.ToString();

        }

        private void BtnCpt_Click(object sender, EventArgs e)
        {
            ServiceReference1.compte[] cptes=stub.getComptes();
            DataTable dt=new DataTable("Comptes");
            dt.Columns.Add("Code");
            dt.Columns.Add("Solde");
            for (int i = 0; i < cptes.Length; i++)
            {
                dt.Rows.Add(cptes[i].code,cptes[i].solde);
                dataGridView1.DataSource = dt;

            }

        }
    }
}
