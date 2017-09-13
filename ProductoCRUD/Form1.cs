using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoCRUD
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
