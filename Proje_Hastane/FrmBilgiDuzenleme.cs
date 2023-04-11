using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmBilgiDuzenleme : Form
    {
        public FrmBilgiDuzenleme()
        {
            InitializeComponent();
        }

        public string TCno;
        private void FrmBilgiDuzenleme_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
        }
    }
}
