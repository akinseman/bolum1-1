using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bölüm1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHsapla_Click(object sender, EventArgs e)
        {
            int YAS;
            YAS = Convert.ToInt32(txtyas.Text);
            if (YAS<18)
            {
                lblDurum.Text = "araba kulamk için büyümelisin lazım";
            }
            if (YAS>=18)
            {
                lblDurum.Text = "araba kulana bilirsin";
            }

        }
    }
}
