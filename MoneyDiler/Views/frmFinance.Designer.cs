namespace MoneyDiler
{
    partial class frmFinance
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
            this.lblErrorCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategorySub = new System.Windows.Forms.ComboBox();
            this.lblCategorySub = new System.Windows.Forms.Label();
            this.cmbPaymentForm = new System.Windows.Forms.ComboBox();
            this.lblPaymentForm = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblSituation = new System.Windows.Forms.Label();
            this.rbSituationPago = new System.Windows.Forms.RadioButton();
            this.rbSituationPendente = new System.Windows.Forms.RadioButton();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblErrorCategorySub = new System.Windows.Forms.Label();
            this.lblErrorPaymentForm = new System.Windows.Forms.Label();
            this.lblErrorDateTime = new System.Windows.Forms.Label();
            this.lblErrorSituation = new System.Windows.Forms.Label();
            this.lblErrorPriority = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblErrorValue = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscarCategorySub = new System.Windows.Forms.ComboBox();
            this.lblBuscarCategorySub = new System.Windows.Forms.Label();
            this.cmbBuscarCategory = new System.Windows.Forms.ComboBox();
            this.lblBuscarCategory = new System.Windows.Forms.Label();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPaymentForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorCategory
            // 
            this.lblErrorCategory.AutoSize = true;
            this.lblErrorCategory.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategory.Location = new System.Drawing.Point(368, 21);
            this.lblErrorCategory.Name = "lblErrorCategory";
            this.lblErrorCategory.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCategory.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(112, 16);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(6, 16);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Categoria:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategorySub
            // 
            this.cmbCategorySub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorySub.FormattingEnabled = true;
            this.cmbCategorySub.Location = new System.Drawing.Point(112, 43);
            this.cmbCategorySub.Name = "cmbCategorySub";
            this.cmbCategorySub.Size = new System.Drawing.Size(250, 21);
            this.cmbCategorySub.TabIndex = 5;
            // 
            // lblCategorySub
            // 
            this.lblCategorySub.Location = new System.Drawing.Point(6, 43);
            this.lblCategorySub.Name = "lblCategorySub";
            this.lblCategorySub.Size = new System.Drawing.Size(100, 23);
            this.lblCategorySub.TabIndex = 4;
            this.lblCategorySub.Text = "Sub-Categoria:";
            this.lblCategorySub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPaymentForm
            // 
            this.cmbPaymentForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentForm.FormattingEnabled = true;
            this.cmbPaymentForm.Location = new System.Drawing.Point(112, 70);
            this.cmbPaymentForm.Name = "cmbPaymentForm";
            this.cmbPaymentForm.Size = new System.Drawing.Size(250, 21);
            this.cmbPaymentForm.TabIndex = 8;
            // 
            // lblPaymentForm
            // 
            this.lblPaymentForm.Location = new System.Drawing.Point(6, 70);
            this.lblPaymentForm.Name = "lblPaymentForm";
            this.lblPaymentForm.Size = new System.Drawing.Size(100, 23);
            this.lblPaymentForm.TabIndex = 7;
            this.lblPaymentForm.Text = "Forma de Pgto.:";
            this.lblPaymentForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Location = new System.Drawing.Point(6, 123);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(100, 23);
            this.lblDateTime.TabIndex = 13;
            this.lblDateTime.Text = "Data/Hora:";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDateTime
            // 
            this.dtDateTime.Checked = false;
            this.dtDateTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateTime.Location = new System.Drawing.Point(112, 123);
            this.dtDateTime.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtDateTime.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtDateTime.Name = "dtDateTime";
            this.dtDateTime.Size = new System.Drawing.Size(151, 20);
            this.dtDateTime.TabIndex = 14;
            // 
            // lblSituation
            // 
            this.lblSituation.Location = new System.Drawing.Point(6, 146);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(100, 23);
            this.lblSituation.TabIndex = 16;
            this.lblSituation.Text = "Situação:";
            this.lblSituation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbSituationPago
            // 
            this.rbSituationPago.AutoSize = true;
            this.rbSituationPago.Checked = true;
            this.rbSituationPago.Location = new System.Drawing.Point(112, 149);
            this.rbSituationPago.Name = "rbSituationPago";
            this.rbSituationPago.Size = new System.Drawing.Size(50, 17);
            this.rbSituationPago.TabIndex = 17;
            this.rbSituationPago.TabStop = true;
            this.rbSituationPago.Text = "Pago";
            this.rbSituationPago.UseVisualStyleBackColor = true;
            // 
            // rbSituationPendente
            // 
            this.rbSituationPendente.AutoSize = true;
            this.rbSituationPendente.Location = new System.Drawing.Point(168, 149);
            this.rbSituationPendente.Name = "rbSituationPendente";
            this.rbSituationPendente.Size = new System.Drawing.Size(71, 17);
            this.rbSituationPendente.TabIndex = 18;
            this.rbSituationPendente.Text = "Pendente";
            this.rbSituationPendente.UseVisualStyleBackColor = true;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(112, 172);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(86, 21);
            this.cmbPriority.TabIndex = 21;
            // 
            // lblPriority
            // 
            this.lblPriority.Location = new System.Drawing.Point(6, 172);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(100, 23);
            this.lblPriority.TabIndex = 20;
            this.lblPriority.Text = "Prioridade:";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(6, 197);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 23);
            this.lblText.TabIndex = 23;
            this.lblText.Text = "Descrição:";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(112, 199);
            this.txtText.MaxLength = 255;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(356, 20);
            this.txtText.TabIndex = 24;
            // 
            // lblErrorCategorySub
            // 
            this.lblErrorCategorySub.AutoSize = true;
            this.lblErrorCategorySub.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategorySub.Location = new System.Drawing.Point(368, 48);
            this.lblErrorCategorySub.Name = "lblErrorCategorySub";
            this.lblErrorCategorySub.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCategorySub.TabIndex = 6;
            // 
            // lblErrorPaymentForm
            // 
            this.lblErrorPaymentForm.AutoSize = true;
            this.lblErrorPaymentForm.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPaymentForm.Location = new System.Drawing.Point(368, 75);
            this.lblErrorPaymentForm.Name = "lblErrorPaymentForm";
            this.lblErrorPaymentForm.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPaymentForm.TabIndex = 9;
            // 
            // lblErrorDateTime
            // 
            this.lblErrorDateTime.AutoSize = true;
            this.lblErrorDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDateTime.Location = new System.Drawing.Point(269, 128);
            this.lblErrorDateTime.Name = "lblErrorDateTime";
            this.lblErrorDateTime.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDateTime.TabIndex = 15;
            // 
            // lblErrorSituation
            // 
            this.lblErrorSituation.AutoSize = true;
            this.lblErrorSituation.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSituation.Location = new System.Drawing.Point(245, 151);
            this.lblErrorSituation.Name = "lblErrorSituation";
            this.lblErrorSituation.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSituation.TabIndex = 19;
            // 
            // lblErrorPriority
            // 
            this.lblErrorPriority.AutoSize = true;
            this.lblErrorPriority.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPriority.Location = new System.Drawing.Point(204, 177);
            this.lblErrorPriority.Name = "lblErrorPriority";
            this.lblErrorPriority.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPriority.TabIndex = 22;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(355, 227);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 28;
            this.txtId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(112, 225);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(112, 97);
            this.txtValue.MaxLength = 50;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(142, 20);
            this.txtValue.TabIndex = 11;
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(6, 94);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(100, 23);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Valor: R$ ";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrorValue
            // 
            this.lblErrorValue.AutoSize = true;
            this.lblErrorValue.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValue.Location = new System.Drawing.Point(260, 99);
            this.lblErrorValue.Name = "lblErrorValue";
            this.lblErrorValue.Size = new System.Drawing.Size(0, 13);
            this.lblErrorValue.TabIndex = 12;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.cmbBuscarCategorySub);
            this.grpBuscar.Controls.Add(this.lblBuscarCategorySub);
            this.grpBuscar.Controls.Add(this.cmbBuscarCategory);
            this.grpBuscar.Controls.Add(this.lblBuscarCategory);
            this.grpBuscar.Location = new System.Drawing.Point(12, 275);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(676, 76);
            this.grpBuscar.TabIndex = 29;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(112, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBuscarCategorySub
            // 
            this.cmbBuscarCategorySub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCategorySub.FormattingEnabled = true;
            this.cmbBuscarCategorySub.Location = new System.Drawing.Point(468, 16);
            this.cmbBuscarCategorySub.Name = "cmbBuscarCategorySub";
            this.cmbBuscarCategorySub.Size = new System.Drawing.Size(172, 21);
            this.cmbBuscarCategorySub.TabIndex = 33;
            // 
            // lblBuscarCategorySub
            // 
            this.lblBuscarCategorySub.Location = new System.Drawing.Point(362, 16);
            this.lblBuscarCategorySub.Name = "lblBuscarCategorySub";
            this.lblBuscarCategorySub.Size = new System.Drawing.Size(100, 23);
            this.lblBuscarCategorySub.TabIndex = 32;
            this.lblBuscarCategorySub.Text = "Sub-Categoria:";
            this.lblBuscarCategorySub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBuscarCategory
            // 
            this.cmbBuscarCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCategory.FormattingEnabled = true;
            this.cmbBuscarCategory.Location = new System.Drawing.Point(112, 16);
            this.cmbBuscarCategory.Name = "cmbBuscarCategory";
            this.cmbBuscarCategory.Size = new System.Drawing.Size(172, 21);
            this.cmbBuscarCategory.TabIndex = 31;
            this.cmbBuscarCategory.SelectedValueChanged += new System.EventHandler(this.cmbBuscarCategory_SelectedValueChanged);
            // 
            // lblBuscarCategory
            // 
            this.lblBuscarCategory.Location = new System.Drawing.Point(6, 16);
            this.lblBuscarCategory.Name = "lblBuscarCategory";
            this.lblBuscarCategory.Size = new System.Drawing.Size(100, 23);
            this.lblBuscarCategory.TabIndex = 30;
            this.lblBuscarCategory.Text = "Categoria:";
            this.lblBuscarCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.clCategory,
            this.clValue,
            this.clDate,
            this.clSituation,
            this.clPaymentForm,
            this.clPriority});
            this.dgList.Location = new System.Drawing.Point(12, 357);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(676, 131);
            this.dgList.TabIndex = 35;
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
            // clCategory
            // 
            this.clCategory.HeaderText = "Categoria";
            this.clCategory.MinimumWidth = 100;
            this.clCategory.Name = "clCategory";
            this.clCategory.ReadOnly = true;
            this.clCategory.Width = 170;
            // 
            // clValue
            // 
            this.clValue.HeaderText = "Valor";
            this.clValue.MinimumWidth = 50;
            this.clValue.Name = "clValue";
            this.clValue.ReadOnly = true;
            this.clValue.Width = 80;
            // 
            // clDate
            // 
            this.clDate.HeaderText = "Data";
            this.clDate.Name = "clDate";
            this.clDate.ReadOnly = true;
            // 
            // clSituation
            // 
            this.clSituation.HeaderText = "Situação";
            this.clSituation.MinimumWidth = 40;
            this.clSituation.Name = "clSituation";
            this.clSituation.ReadOnly = true;
            this.clSituation.Width = 70;
            // 
            // clPaymentForm
            // 
            this.clPaymentForm.HeaderText = "Conta";
            this.clPaymentForm.Name = "clPaymentForm";
            this.clPaymentForm.ReadOnly = true;
            // 
            // clPriority
            // 
            this.clPriority.HeaderText = "Prioridade";
            this.clPriority.MinimumWidth = 30;
            this.clPriority.Name = "clPriority";
            this.clPriority.ReadOnly = true;
            this.clPriority.Width = 80;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(274, 225);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.cmbCategory);
            this.grpDados.Controls.Add(this.btnExcluir);
            this.grpDados.Controls.Add(this.lblCategory);
            this.grpDados.Controls.Add(this.lblErrorCategory);
            this.grpDados.Controls.Add(this.lblCategorySub);
            this.grpDados.Controls.Add(this.lblErrorValue);
            this.grpDados.Controls.Add(this.cmbCategorySub);
            this.grpDados.Controls.Add(this.txtValue);
            this.grpDados.Controls.Add(this.lblPaymentForm);
            this.grpDados.Controls.Add(this.lblValue);
            this.grpDados.Controls.Add(this.cmbPaymentForm);
            this.grpDados.Controls.Add(this.txtId);
            this.grpDados.Controls.Add(this.lblDateTime);
            this.grpDados.Controls.Add(this.btnCancelar);
            this.grpDados.Controls.Add(this.dtDateTime);
            this.grpDados.Controls.Add(this.btnSalvar);
            this.grpDados.Controls.Add(this.lblSituation);
            this.grpDados.Controls.Add(this.lblErrorPriority);
            this.grpDados.Controls.Add(this.rbSituationPago);
            this.grpDados.Controls.Add(this.rbSituationPendente);
            this.grpDados.Controls.Add(this.lblErrorSituation);
            this.grpDados.Controls.Add(this.lblPriority);
            this.grpDados.Controls.Add(this.lblErrorDateTime);
            this.grpDados.Controls.Add(this.cmbPriority);
            this.grpDados.Controls.Add(this.lblErrorPaymentForm);
            this.grpDados.Controls.Add(this.lblText);
            this.grpDados.Controls.Add(this.lblErrorCategorySub);
            this.grpDados.Controls.Add(this.txtText);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(676, 257);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados";
            // 
            // frmFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.ControlBox = false;
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.grpBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(170, 0);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmFinance_Load);
            this.grpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblErrorCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategorySub;
        private System.Windows.Forms.Label lblCategorySub;
        private System.Windows.Forms.ComboBox cmbPaymentForm;
        private System.Windows.Forms.Label lblPaymentForm;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtDateTime;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.RadioButton rbSituationPago;
        private System.Windows.Forms.RadioButton rbSituationPendente;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblErrorCategorySub;
        private System.Windows.Forms.Label lblErrorPaymentForm;
        private System.Windows.Forms.Label lblErrorDateTime;
        private System.Windows.Forms.Label lblErrorSituation;
        private System.Windows.Forms.Label lblErrorPriority;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblErrorValue;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarCategorySub;
        private System.Windows.Forms.Label lblBuscarCategorySub;
        private System.Windows.Forms.ComboBox cmbBuscarCategory;
        private System.Windows.Forms.Label lblBuscarCategory;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSituation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPaymentForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPriority;
    }
}