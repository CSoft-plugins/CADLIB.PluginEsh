using CADLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin
{
    public partial class Form1 : Form, ICADLibPlugin
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MenuStrip GetMenu()
        {
            return menuStrip1;
        }

        public ToolStripContainer GetToolbars()
        {
            return null;
        }

        public void TrackInterfaceItems(InterfaceTracker tracker)
        {

        }

        private void плагинТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2())
            {
                form2.ShowDialog();
            }
        }
    }
}
