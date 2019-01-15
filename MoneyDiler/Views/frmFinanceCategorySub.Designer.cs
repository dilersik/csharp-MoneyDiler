namespace MoneyDiler
{
    partial class frmFinanceCategorySub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblErrorType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblErrorCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscarCategory = new System.Windows.Forms.ComboBox();
            this.lblBuscarCategory = new System.Windows.Forms.Label();
            this.cmbBuscarType = new System.Windows.Forms.ComboBox();
            this.lblBuscarType = new System.Windows.Forms.Label();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.grpBuscar.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.ForeColor = System.Drawing.Color.Red;
            this.lblErrorType.Location = new System.Drawing.Point(239, 19);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(0, 13);
            this.lblErrorType.TabIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(112, 16);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 2;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(6, 16);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Tipo:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(355, 98);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(112, 96);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(368, 73);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 13);
            this.lblErrorName.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 70);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nome:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrorCategory
            // 
            this.lblErrorCategory.AutoSize = true;
            this.lblErrorCategory.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategory.Location = new System.Drawing.Point(368, 48);
            this.lblErrorCategory.Name = "lblErrorCategory";
            this.lblErrorCategory.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCategory.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(112, 43);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 21);
            this.cmbCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(6, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Categoria:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clName,
            this.clCategory});
            this.dgList.Location = new System.Drawing.Point(12, 230);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(676, 258);
            this.dgList.TabIndex = 20;
            this.dgList.DoubleClick += new System.EventHandler(this.dgList_DoubleClick);
            // 
            // clId
            // 
            this.clId.HeaderText = "Id";
            this.clId.MinimumWidth = 30;
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 80;
            // 
            // clName
            // 
            this.clName.HeaderText = "Nome";
            this.clName.MinimumWidth = 100;
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 250;
            // 
            // clCategory
            // 
            this.clCategory.HeaderText = "Categoria";
            this.clCategory.MinimumWidth = 100;
            this.clCategory.Name = "clCategory";
            this.clCategory.ReadOnly = true;
            this.clCategory.Width = 190;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.cmbBuscarCategory);
            this.grpBuscar.Controls.Add(this.lblBuscarCategory);
            this.grpBuscar.Controls.Add(this.cmbBuscarType);
            this.grpBuscar.Controls.Add(this.lblBuscarType);
            this.grpBuscar.Location = new System.Drawing.Point(12, 146);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(676, 78);
            this.grpBuscar.TabIndex = 14;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(106, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBuscarCategory
            // 
            this.cmbBuscarCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCategory.FormattingEnabled = true;
            this.cmbBuscarCategory.Location = new System.Drawing.Point(339, 19);
            this.cmbBuscarCategory.Name = "cmbBuscarCategory";
            this.cmbBuscarCategory.Size = new System.Drawing.Size(250, 21);
            this.cmbBuscarCategory.TabIndex = 18;
            // 
            // lblBuscarCategory
            // 
            this.lblBuscarCategory.Location = new System.Drawing.Point(233, 19);
            this.lblBuscarCategory.Name = "lblBuscarCategory";
            this.lblBuscarCategory.Size = new System.Drawing.Size(100, 23);
            this.lblBuscarCategory.TabIndex = 17;
            this.lblBuscarCategory.Text = "Categoria:";
            this.lblBuscarCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBuscarType
            // 
            this.cmbBuscarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarType.FormattingEnabled = true;
            this.cmbBuscarType.Location = new System.Drawing.Point(106, 19);
            this.cmbBuscarType.Name = "cmbBuscarType";
            this.cmbBuscarType.Size = new System.Drawing.Size(121, 21);
            this.cmbBuscarType.TabIndex = 16;
            this.cmbBuscarType.SelectedValueChanged += new System.EventHandler(this.cmbBuscarType_SelectedValueChanged);
            // 
            // lblBuscarType
            // 
            this.lblBuscarType.Location = new System.Drawing.Point(6, 19);
            this.lblBuscarType.Name = "lblBuscarType";
            this.lblBuscarType.Size = new System.Drawing.Size(94, 23);
            this.lblBuscarType.TabIndex = 15;
            this.lblBuscarType.Text = "Tipo:";
            this.lblBuscarType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDados
            // 
            this.grpDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDados.Controls.Add(this.btnExcluir);
            this.grpDados.Controls.Add(this.cmbType);
            this.grpDados.Controls.Add(this.lblType);
            this.grpDados.Controls.Add(this.lblErrorType);
            this.grpDados.Controls.Add(this.lblErrorCategory);
            this.grpDados.Controls.Add(this.lblName);
            this.grpDados.Controls.Add(this.cmbCategory);
            this.grpDados.Controls.Add(this.txtName);
            this.grpDados.Controls.Add(this.lblCategory);
            this.grpDados.Controls.Add(this.lblErrorName);
            this.grpDados.Controls.Add(this.txtId);
            this.grpDados.Controls.Add(this.btnSalvar);
            this.grpDados.Controls.Add(this.btnCancelar);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(676, 128);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(274, 96);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmFinanceCategorySub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.dgList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(170, 0);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmFinanceCategorySub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmFinanceCategorySub";
            this.Load += new System.EventHandler(this.frmFinanceCategorySub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblErrorCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarCategory;
        private System.Windows.Forms.Label lblBuscarCategory;
        private System.Windows.Forms.ComboBox cmbBuscarType;
        private System.Windows.Forms.Label lblBuscarType;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.Button btnExcluir;
    }
}