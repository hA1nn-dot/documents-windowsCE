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
            this.btnCleanFields = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxDocTypes = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radiobtn_NumDocument = new System.Windows.Forms.RadioButton();
            this.radioBtn_documentBarcode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.razonSocialLabel = new System.Windows.Forms.Label();
            this.documentTypeLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.listProducts = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(32, 54);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(175, 23);
            this.txtDocument.TabIndex = 1;
            this.txtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocument_KeyPress);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBarcode.Location = new System.Drawing.Point(0, 10);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(226, 23);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 33);
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.Location = new System.Drawing.Point(75, 112);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(72, 20);
            this.btnCleanFields.TabIndex = 3;
            this.btnCleanFields.Text = "Limpiar";
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.labelTipo);
            this.panel2.Controls.Add(this.btnCleanFields);
            this.panel2.Controls.Add(this.comboBoxDocTypes);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.razonSocialLabel);
            this.panel2.Controls.Add(this.documentTypeLabel);
            this.panel2.Controls.Add(this.clientNameLabel);
            this.panel2.Controls.Add(this.txtDocument);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 225);
            // 
            // labelTipo
            // 
            this.labelTipo.Location = new System.Drawing.Point(32, 86);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(37, 20);
            this.labelTipo.Text = "Tipo:";
            // 
            // comboBoxDocTypes
            // 
            this.comboBoxDocTypes.Location = new System.Drawing.Point(75, 83);
            this.comboBoxDocTypes.Name = "comboBoxDocTypes";
            this.comboBoxDocTypes.Size = new System.Drawing.Size(132, 23);
            this.comboBoxDocTypes.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radiobtn_NumDocument);
            this.panel3.Controls.Add(this.radioBtn_documentBarcode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 28);
            // 
            // radiobtn_NumDocument
            // 
            this.radiobtn_NumDocument.Location = new System.Drawing.Point(3, 3);
            this.radiobtn_NumDocument.Name = "radiobtn_NumDocument";
            this.radiobtn_NumDocument.Size = new System.Drawing.Size(141, 20);
            this.radiobtn_NumDocument.TabIndex = 4;
            this.radiobtn_NumDocument.Text = "Num. Documento";
            this.radiobtn_NumDocument.CheckedChanged += new System.EventHandler(this.radiobtn_NumDocument_CheckedChanged);
            // 
            // radioBtn_documentBarcode
            // 
            this.radioBtn_documentBarcode.Location = new System.Drawing.Point(150, 3);
            this.radioBtn_documentBarcode.Name = "radioBtn_documentBarcode";
            this.radioBtn_documentBarcode.Size = new System.Drawing.Size(73, 20);
            this.radioBtn_documentBarcode.TabIndex = 5;
            this.radioBtn_documentBarcode.Text = "Código";
            this.radioBtn_documentBarcode.CheckedChanged += new System.EventHandler(this.radioBtn_documentBarcode_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            // 
            // razonSocialLabel
            // 
            this.razonSocialLabel.Location = new System.Drawing.Point(12, 196);
            this.razonSocialLabel.Name = "razonSocialLabel";
            this.razonSocialLabel.Size = new System.Drawing.Size(179, 20);
            // 
            // documentTypeLabel
            // 
            this.documentTypeLabel.Location = new System.Drawing.Point(12, 176);
            this.documentTypeLabel.Name = "documentTypeLabel";
            this.documentTypeLabel.Size = new System.Drawing.Size(179, 20);
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.Location = new System.Drawing.Point(12, 156);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(179, 20);
            // 
            // listProducts
            // 
            this.listProducts.CheckBoxes = true;
            this.listProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProducts.FullRowSelect = true;
            this.listProducts.Location = new System.Drawing.Point(0, 0);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(226, 192);
            this.listProducts.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(234, 254);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(226, 225);
            this.tabPage1.Text = "Documento";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listProducts);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(226, 225);
            this.tabPage2.Text = "Productos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(234, 254);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCleanFields;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label razonSocialLabel;
        private System.Windows.Forms.Label documentTypeLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.ListView listProducts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiobtn_NumDocument;
        private System.Windows.Forms.RadioButton radioBtn_documentBarcode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox comboBoxDocTypes;
    }
}

