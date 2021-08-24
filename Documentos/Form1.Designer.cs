namespace Documentos.Connection
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCleanFields = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.razonSocialLabel = new System.Windows.Forms.Label();
            this.documentTypeLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.listProducts = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDocument.Location = new System.Drawing.Point(0, 0);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(234, 23);
            this.txtDocument.TabIndex = 1;
            this.txtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBarcode.Location = new System.Drawing.Point(0, 27);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(234, 23);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.btnCleanFields);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 50);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(159, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(72, 20);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Enviar";
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.Location = new System.Drawing.Point(3, 3);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(72, 20);
            this.btnCleanFields.TabIndex = 3;
            this.btnCleanFields.Text = "Limpiar";
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.razonSocialLabel);
            this.panel2.Controls.Add(this.documentTypeLabel);
            this.panel2.Controls.Add(this.clientNameLabel);
            this.panel2.Controls.Add(this.txtDocument);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 89);
            // 
            // razonSocialLabel
            // 
            this.razonSocialLabel.Location = new System.Drawing.Point(3, 66);
            this.razonSocialLabel.Name = "razonSocialLabel";
            this.razonSocialLabel.Size = new System.Drawing.Size(228, 20);
            // 
            // documentTypeLabel
            // 
            this.documentTypeLabel.Location = new System.Drawing.Point(3, 46);
            this.documentTypeLabel.Name = "documentTypeLabel";
            this.documentTypeLabel.Size = new System.Drawing.Size(228, 20);
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.Location = new System.Drawing.Point(3, 26);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(228, 20);
            // 
            // listProducts
            // 
            this.listProducts.CheckBoxes = true;
            this.listProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProducts.FullRowSelect = true;
            this.listProducts.Location = new System.Drawing.Point(0, 89);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(234, 115);
            this.listProducts.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(234, 254);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCleanFields;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label razonSocialLabel;
        private System.Windows.Forms.Label documentTypeLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.ListView listProducts;
    }
}

