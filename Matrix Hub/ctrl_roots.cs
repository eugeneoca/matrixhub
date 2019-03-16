using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Hub
{
    public partial class ctrl_roots : UserControl
    {

        private static ctrl_roots _instance;
        public static ctrl_roots Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ctrl_roots();
                return _instance;
            }
        }

        public ctrl_roots()
        {
            InitializeComponent();
        }

        private void ctrl_roots_Load(object sender, EventArgs e)
        {

        }

        public void set_value(string value)
        {
            this.lbl_root.Text = value;
        }
    }
}
