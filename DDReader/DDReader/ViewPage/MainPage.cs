using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDReader
{
    
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

          

        private void oracleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPage.AddOracleSource addOracleSource = new ViewPage.AddOracleSource();
            addOracleSource.ShowDialog();
        }
    }
}
