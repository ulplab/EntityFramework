using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;


namespace EntityDataBaseFirst
{
    public partial class frmCategorías : Form
    {
        private BindingSource bs;
        private EmpresaDB db;

        public frmCategorías()
        {
            InitializeComponent();
            bs = new BindingSource();
            db = new EmpresaDB();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            db.Categoria.Load();
            //bs.DataSource = null;
            bs.DataSource = db.Categoria.Local.ToBindingList();
            dgvCategorías.DataSource = bs;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            db.Categoria.Local.Clear();
            db.SaveChanges();
            //db.Database.ExecuteSqlCommand("Delete from [Categoria];");
            Listar();
        }

        private void frmCategorías_Load(object sender, EventArgs e)
        {
            Listar();            
        }

        private void dgvCategorías_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            //var q = db.Categoria;
            //Categoria c1 = db.Categoria.FirstOrDefault(cat => cat.CategoriaId == 17);
            //    //from cat in db.Categoria where cat.CategoriaId == 17 select cat;
            //c1.Nombre = "Juana";
            

        }
    }
}
