using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CategoriaCRUD
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
            dgvCategorias.AutoGenerateColumns = false;
            Listar();
        }

        private void Listar()
        {
            using (EmpresaDB db = new EmpresaDB())
            {
                dgvCategorias.DataSource = db.Categoria.ToList();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (EmpresaDB db = new EmpresaDB())
            {
                int id = Int32.Parse(tbBuscar.Text);
                Categoria categoria = db.Categoria.FirstOrDefault(cat => cat.CategoriaId == id);
                if (categoria != null)
                {
                    tbNombre.Text = categoria.Nombre;
                    cbEstado.Checked = categoria.Estado;
                }
                else {
                    MessageBox.Show("No se encotró ninguna categoría con el Id especificado");
                }
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (EmpresaDB db = new EmpresaDB()) {
                Categoria categoria = new Categoria();
                categoria.Nombre = tbNombre.Text;
                categoria.Estado = cbEstado.Checked;
                db.Categoria.Add(categoria);
                db.SaveChanges();
                Listar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            using (EmpresaDB db = new EmpresaDB()) {
                Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                //Opcion 1: Ajuntar la entidad a este DbContext porque la misma fue cargada por una instancia diferente de EmpresaDB
                //db.Categoria.Attach(categoria);

                //Opcion 2: Buscar la entidad por ID y luego borrarla
                Categoria categoria2 = db.Categoria.FirstOrDefault(cat => cat.CategoriaId == categoria.CategoriaId);

                //List<Categoria> categoria3 = db.Categoria.Where(cat => cat.CategoriaId == 1).ToList();

                db.Categoria.Remove(categoria2);
                db.SaveChanges();
                Listar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (EmpresaDB db = new EmpresaDB())
            {
                Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                //Opcion 1: Ajuntar la entidad a este DbContext porque la misma fue cargada por una instancia diferente de EmpresaDB
                db.Categoria.Attach(categoria);

                //Opcion 2: Buscar la entidad por ID y luego borrarla
                //Categoria categoria2 = db.Categoria.FirstOrDefault(cat => cat.CategoriaId == categoria.CategoriaId);

                categoria.Nombre = tbNombre.Text;
                categoria.Estado = cbEstado.Checked;
                db.SaveChanges();
                Listar();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
