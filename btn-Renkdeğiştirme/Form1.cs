using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btn_Renkdeğiştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            btnKirmizi.BackColor = Color.Red;
            this.BackColor = Color.Red; 
            this.ForeColor=Color.White;
            MessageBox.Show("form rengi kırmızı olarak ayarlandı");
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            btnMavi.BackColor = Color.Blue;
            this.BackColor = Color.Blue;
            this.ForeColor = Color.White;
            MessageBox.Show("form rengi mavi olarak ayarlandı");
        }
    }
}
