namespace MoneyDiler
{
    partial class frmPaymentForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.lblErrorInitialBalance = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInitialBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpDados = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 18);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(6, 44);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipo:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(112, 44);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 5;
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.Location = new System.Drawing.Point(6, 68);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(100, 23);
            this.lblInitialBalance.TabIndex = 7;
            this.lblInitialBalance.Text = "Saldo Inicial: R$ ";
            this.lblInitialBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Location = new System.Drawing.Point(112, 71);
            this.txtInitialBalance.MaxLength = 50;
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(142, 20);
            this.txtInitialBalance.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(112, 97);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(368, 21);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 13);
            this.lblErrorName.TabIndex = 3;
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.ForeColor = System.Drawing.Color.Red;
            this.lblErrorType.Location = new System.Drawing.Point(240, 51);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(0, 13);
            this.lblErrorType.TabIndex = 6;
            // 
            // lblErrorInitialBalance
            // 
            this.lblErrorInitialBalance.AutoSize = true;
            this.lblErrorInitialBalance.ForeColor = System.Drawing.Color.Red;
            this.lblErrorInitialBalance.Location = new System.Drawing.Point(260, 73);
            this.lblErrorInitialBalance.Name = "lblErrorInitialBalance";
            this.lblErrorInitialBalance.Size = new System.Drawing.Size(0, 13);
            this.lblErrorInitialBalance.TabIndex = 9;
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
            this.clType,
            this.clInitialBalance});
            this.dgList.Location = new System.Drawing.Point(12, 148);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(676, 340);
            this.dgList.TabIndex = 14;
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
            this.clName.Width = 160;
            // 
            // clType
            // 
            this.clType.HeaderText = "Tipo";
            this.clType.MinimumWidth = 100;
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            this.clType.Width = 160;
            // 
            // clInitialBalance
            // 
            this.clInitialBalance.HeaderText = "Saldo Inicial";
            this.clInitialBalance.MinimumWidth = 80;
            this.clInitialBalance.Name = "clInitialBalance";
            this.clInitialBalance.ReadOnly = true;
            this.clInitialBalance.Width = 150;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(355, 99);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(274, 97);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grpDados
            // 
            this.grpDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDados.Controls.Add(this.txtName);
            this.grpDados.Controls.Add(this.btnExcluir);
            this.grpDados.Controls.Add(this.lblName);
            this.grpDados.Controls.Add(this.txtId);
            this.grpDados.Controls.Add(this.lblType);
            this.grpDados.Controls.Add(this.cmbType);
            this.grpDados.Controls.Add(this.lblErrorInitialBalance);
            this.grpDados.Controls.Add(this.lblInitialBalance);
            this.grpDados.Controls.Add(this.lblErrorType);
            this.grpDados.Controls.Add(this.txtInitialBalance);
            this.grpDados.Controls.Add(this.lblErrorName);
            this.grpDados.Controls.Add(this.btnSalvar);
            this.grpDados.Controls.Add(this.btnCancelar);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(676, 130);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados";
            // 
            // frmPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.dgList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(170, 0);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblInitialBalance;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.Label lblErrorInitialBalance;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInitialBalance;

    }
}