using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Documentos.Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;

            listProducts.View = View.Details;
            listProducts.Columns.Add("Cant", -2, HorizontalAlignment.Left);
            listProducts.Columns.Add("Clave", -2, HorizontalAlignment.Left);
            listProducts.Columns.Add("Unidad", -2, HorizontalAlignment.Left);
            listProducts.Columns.Add("Producto", -2, HorizontalAlignment.Left);
            txtDocument.Focus();

        }

        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                string documentID = txtDocument.Text.ToString().Trim();
                try
                {
                    SQLFunction function = new SQLFunction();
                    function.setDocumentAttributes(documentID);
                    printDocumentInformation();
                    printProducts();
                }
                catch (SqlException err) {
                    MessageBox.Show(err.Message.ToString());
                }
                
            }
        }
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e) {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                searchProduct();
            }
        }

        private void searchProduct() {
            string barcode = txtBarcode.Text;
            txtBarcode.Text = "";
            Document doc = Document.getInstance();
            foreach (Product producto in doc.getListProducts()) {
                if (producto.getBarcode() == barcode || producto.getClave() == barcode)
                {
                    MessageBox.Show("selected");
                }
            }
            
            

        }

        private void printDocumentInformation(){
            Document doc = Document.getInstance();
            clientNameLabel.Text = "Nombre del Cliente: "+doc.getClientName();
            razonSocialLabel.Text = "Razón Social: "+doc.getRazonSocial();
            documentTypeLabel.Text = "Tipo Documento: "+doc.getDocumentType();
        }

        private void printProducts() {
            listProducts.View = View.Details;
            Document doc = Document.getInstance();
            foreach (Product producto in doc.getListProducts()) {
                ListViewItem item = new ListViewItem(producto.getAmount());
                item.SubItems.Add(producto.getClave());
                item.SubItems.Add(producto.getUnit());
                item.SubItems.Add(producto.getDescription());
                listProducts.Items.Add(item);
            }
        }

        private void productsDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            listProducts.Clear();
            documentTypeLabel.Text = "";
            clientNameLabel.Text = "";
            razonSocialLabel.Text = "";
            txtDocument.Text = "";
            txtDocument.Focus();
            Document.destroy();
        }

    }
}