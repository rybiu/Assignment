using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagement
{
    public partial class MenuItem : UserControl
    {
        public MenuItem(string item)
        {
            InitializeComponent();
            lbMenuItem.Text = item;
        }

        public void resetColor()
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            lbIndicator.Visible = false;
        }
        public void focusColor()
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            lbIndicator.Visible = true;
        }

    }
}
