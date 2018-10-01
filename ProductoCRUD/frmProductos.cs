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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            using (EmpresaDB db = new EmpresaDB())
            {
                List<Categoria> categorias = db.Categoria.ToList();

                cboCategorias.DisplayMember = "Nombre";
                cboCategorias.ValueMember = "CategoriaId";
                cboCategorias.DataSource = categorias;
            }
            Listar();

        }

        private void ReiniciaCampos() {
            tbBuscar.Clear();
            tbCosto.Clear();
            tbDescripcion.Clear();
            tbUtilidad.Clear();
            cbEstado.Checked = true;
            cboCategorias.SelectedIndex = 0;
        }

        private void Listar()
        {
            using (EmpresaDB db = new EmpresaDB())
            {
                List<ListaProductos> lista = (from prods in db.Producto
                                              join cat in db.Categoria on prods.CategoriaId equals cat.CategoriaId into prodCats
                                              from pc in prodCats.DefaultIfEmpty()
                                              select new ListaProductos()
                                              {
                                                  ProductoId = prods.ProductoId,
                                                  IdCategoria = pc.CategoriaId,
                                                  Descripcion = prods.Descripcion,
                                                  Categoria = pc.Nombre,
                                                  CoefUtil = prods.CoefUtil,
                                                  Costo = prods.Costo,
                                                  Estado = prods.Estado
                                              }).ToList();


                List<ListaProductos> lista2 = db.Producto.Join(db.Categoria,
                    prod => prod.CategoriaId,
                    cat => cat.CategoriaId,
                    (prod, cat) => new { prod, cat }).Select(pc => new ListaProductos()
                    {
                        ProductoId = pc.prod.ProductoId,
                        IdCategoria = pc.cat.CategoriaId,
                        Descripcion = pc.prod.Descripcion,
                        Categoria = pc.cat.Nombre,
                        CoefUtil = pc.prod.CoefUtil,
                        Costo = pc.prod.Costo,
                        Estado = pc.prod.Estado

                    }).ToList();

                List<ListaProductos> lista3 = db.Producto.Select(p => new ListaProductos()
                {
                    ProductoId = p.ProductoId,
                    IdCategoria = p.Categoria.CategoriaId,
                    Descripcion = p.Descripcion,
                    Categoria = p.Categoria.Nombre,
                    CoefUtil = p.CoefUtil,
                    Costo = p.Costo,
                    Estado = p.Estado

                }).ToList();

                dgvProductos.DataSource = lista3;
            }
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Como obtener el objeto categoria del datasource, en este caso 
            //leo la propiedad estado a modo de ejemplo
            bool estado = ((Categoria)cboCategorias.SelectedItem).Estado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (EmpresaDB db = new EmpresaDB())
            {
                int id = (int)cboCategorias.SelectedValue;
                //Categoria categoria = db.Categoria.Where(c => c.CategoriaId == id).FirstOrDefault();

                Producto produco = new Producto()
                {
                    //Categoria = categoria,
                    CategoriaId = id,
                    Descripcion = tbDescripcion.Text,
                    CoefUtil = decimal.Parse(tbUtilidad.Text),
                    Costo = decimal.Parse(tbCosto.Text),
                    Estado = cbEstado.Checked
                };

                db.Producto.Add(produco);
                try
                {
                    db.SaveChanges();
                    ReiniciaCampos();
                    Listar();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error Al guardar el prudcot: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (EmpresaDB db = new EmpresaDB()) {
                int id = Int32.Parse(tbBuscar.Text);
                Producto producto = db.Producto.FirstOrDefault(p => p.ProductoId == id);
                if (producto == null)
                {
                    MessageBox.Show("El producto no se encontró.");
                }
                else {
                    cboCategorias.SelectedValue = producto.Categoria.CategoriaId;
                    tbDescripcion.Text = producto.Descripcion;
                    tbUtilidad.Text = producto.CoefUtil.ToString();
                    tbCosto.Text = producto.Costo.ToString();
                    cbEstado.Checked = producto.Estado;
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
