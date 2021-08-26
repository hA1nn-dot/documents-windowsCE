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
            radiobtn_NumDocument.Checked = true;
            DocumentType.fillDocTypes(comboBoxDocTypes);
            txtDocument.Focus();

        }

        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((int)e.KeyChar == (int)Keys.Enter && txtDocument.Text != "") {
                SQLFunction function = new SQLFunction();
                string documentID = txtDocument.Text.ToString().Trim();
                try
                {
                    if (radiobtn_NumDocument.Checked) {
                        int typeID = DocumentType.getDocumentTypeID(comboBoxDocTypes.SelectedItem.ToString());
                        function.getDocumetByDocumentNumber(documentID,typeID);
                    }
                    else if (radioBtn_documentBarcode.Checked) {
                        function.searchDocumentByBarcode(documentID);
                    }
                    printDocumentInformation();
                    printProducts();
                    disableRadioButtons();
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message.ToString(),"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                }
                catch (Exception errorGenerado) {
                    MessageBox.Show(errorGenerado.Message.ToString(), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e) {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                searchProduct(txtBarcode.Text);
            }
        }

        private void searchProduct(string barcode)
        {
            txtBarcode.Text = "";
            int indexProduct = Document.getInstance().getIndexIsProductExists(barcode);
            if(indexProduct != -1)
                focusProductInListView(indexProduct);
            else MessageBox.Show("Producto no encontrado en el documento","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
        }

        private void focusProductInListView(int indexProduct) {
            listProducts.Focus();
            listProducts.Items[indexProduct].Selected = true;
            listProducts.Items[indexProduct].Focused = true;
            listProducts.EnsureVisible(indexProduct);
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

        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            listProducts.Items.Clear();
            enableRadioButtons();
            documentTypeLabel.Text = "";
            clientNameLabel.Text = "";
            razonSocialLabel.Text = "";
            txtDocument.Text = "";
            txtDocument.Focus();
            Document.destroy();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 1)
                txtBarcode.Focus();
        }

        private void radiobtn_NumDocument_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn_NumDocument.Checked) {
                label1.Text = "Número Documento:";
                comboBoxDocTypes.Visible = true;
                labelTipo.Visible = true;
                txtDocument.Focus();
            }
        }

        private void disableRadioButtons() {
            radiobtn_NumDocument.Enabled = false;
            radioBtn_documentBarcode.Enabled = false;
        }

        private void enableRadioButtons()
        {
            radiobtn_NumDocument.Enabled = true;
            radioBtn_documentBarcode.Enabled = true;
        }

        private void radioBtn_documentBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_documentBarcode.Checked)
            {
                label1.Text = "Código:";
                comboBoxDocTypes.Visible = false;
                labelTipo.Visible = false;
                txtDocument.Focus();
            }
        }

    }
}