using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    public partial class OverView : Form
    {
        public OverView()
        {
            InitializeComponent();
        }

        private void btn_Exit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
