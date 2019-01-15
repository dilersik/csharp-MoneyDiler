namespace MoneyDiler
{
    partial class frmResumo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblResumo = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.dtDateIn = new System.Windows.Forms.DateTimePicker();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.clPaymentForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGanhos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTotais = new System.Windows.Forms.GroupBox();
            this.txtMeuSaldo = new System.Windows.Forms.TextBox();
            this.lblMeuSaldo = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.lblGastos = new System.Windows.Forms.Label();
            this.txtGanhos = new System.Windows.Forms.TextBox();
            this.lblGanhos = new System.Windows.Forms.Label();
            this.chtCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.grpTotais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblResumo.ForeColor = System.Drawing.Color.Green;
            this.lblResumo.Location = new System.Drawing.Point(12, 9);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(187, 20);
            this.lblResumo.TabIndex = 0;
            this.lblResumo.Text = "Resumo das Finanças";
            // 
            // grpBuscar
            // 
            this.grpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuscar.Controls.Add(this.dtDateEnd);
            this.grpBuscar.Controls.Add(this.lblDateEnd);
            this.grpBuscar.Controls.Add(this.dtDateIn);
            this.grpBuscar.Controls.Add(this.lblDateIn);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Location = new System.Drawing.Point(12, 43);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(676, 74);
            this.grpBuscar.TabIndex = 1;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Checked = false;
            this.dtDateEnd.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateEnd.Location = new System.Drawing.Point(464, 16);
            this.dtDateEnd.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtDateEnd.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(151, 20);
            this.dtDateEnd.TabIndex = 5;
            this.dtDateEnd.ValueChanged += new System.EventHandler(this.dtDateEnd_ValueChanged);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.Location = new System.Drawing.Point(358, 16);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(100, 23);
            this.lblDateEnd.TabIndex = 4;
            this.lblDateEnd.Text = "Data Final:";
            this.lblDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDateIn
            // 
            this.dtDateIn.Checked = false;
            this.dtDateIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateIn.Location = new System.Drawing.Point(112, 16);
            this.dtDateIn.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtDateIn.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtDateIn.Name = "dtDateIn";
            this.dtDateIn.Size = new System.Drawing.Size(151, 20);
            this.dtDateIn.TabIndex = 3;
            this.dtDateIn.ValueChanged += new System.EventHandler(this.dtDateIn_ValueChanged);
            // 
            // lblDateIn
            // 
            this.lblDateIn.Location = new System.Drawing.Point(6, 16);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(100, 23);
            this.lblDateIn.TabIndex = 2;
            this.lblDateIn.Text = "Data Inicial:";
            this.lblDateIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(112, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.clPaymentForm,
            this.clGanhos,
            this.clGastos,
            this.clSaldo});
            this.dgList.Location = new System.Drawing.Point(12, 123);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(676, 305);
            this.dgList.TabIndex = 7;
            // 
            // clPaymentForm
            // 
            this.clPaymentForm.HeaderText = "Forma de Pagamento";
            this.clPaymentForm.MinimumWidth = 140;
            this.clPaymentForm.Name = "clPaymentForm";
            this.clPaymentForm.ReadOnly = true;
            this.clPaymentForm.Width = 180;
            // 
            // clGanhos
            // 
            this.clGanhos.HeaderText = "Ganhos";
            this.clGanhos.MinimumWidth = 70;
            this.clGanhos.Name = "clGanhos";
            this.clGanhos.ReadOnly = true;
            this.clGanhos.Width = 130;
            // 
            // clGastos
            // 
            this.clGastos.HeaderText = "Gastos";
            this.clGastos.MinimumWidth = 70;
            this.clGastos.Name = "clGastos";
            this.clGastos.ReadOnly = true;
            this.clGastos.Width = 130;
            // 
            // clSaldo
            // 
            this.clSaldo.HeaderText = "Saldo";
            this.clSaldo.MinimumWidth = 70;
            this.clSaldo.Name = "clSaldo";
            this.clSaldo.ReadOnly = true;
            this.clSaldo.Width = 130;
            // 
            // grpTotais
            // 
            this.grpTotais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTotais.Controls.Add(this.txtMeuSaldo);
            this.grpTotais.Controls.Add(this.lblMeuSaldo);
            this.grpTotais.Controls.Add(this.txtGastos);
            this.grpTotais.Controls.Add(this.lblGastos);
            this.grpTotais.Controls.Add(this.txtGanhos);
            this.grpTotais.Controls.Add(this.lblGanhos);
            this.grpTotais.Location = new System.Drawing.Point(425, 434);
            this.grpTotais.Name = "grpTotais";
            this.grpTotais.Size = new System.Drawing.Size(263, 100);
            this.grpTotais.TabIndex = 9;
            this.grpTotais.TabStop = false;
            this.grpTotais.Text = "Totais:";
            // 
            // txtMeuSaldo
            // 
            this.txtMeuSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMeuSaldo.ForeColor = System.Drawing.Color.Red;
            this.txtMeuSaldo.Location = new System.Drawing.Point(89, 69);
            this.txtMeuSaldo.Name = "txtMeuSaldo";
            this.txtMeuSaldo.ReadOnly = true;
            this.txtMeuSaldo.Size = new System.Drawing.Size(168, 20);
            this.txtMeuSaldo.TabIndex = 15;
            // 
            // lblMeuSaldo
            // 
            this.lblMeuSaldo.AutoSize = true;
            this.lblMeuSaldo.Location = new System.Drawing.Point(22, 72);
            this.lblMeuSaldo.Name = "lblMeuSaldo";
            this.lblMeuSaldo.Size = new System.Drawing.Size(61, 13);
            this.lblMeuSaldo.TabIndex = 14;
            this.lblMeuSaldo.Text = "Meu Saldo:";
            // 
            // txtGastos
            // 
            this.txtGastos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGastos.ForeColor = System.Drawing.Color.Red;
            this.txtGastos.Location = new System.Drawing.Point(89, 43);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.ReadOnly = true;
            this.txtGastos.Size = new System.Drawing.Size(168, 20);
            this.txtGastos.TabIndex = 13;
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.ForeColor = System.Drawing.Color.Red;
            this.lblGastos.Location = new System.Drawing.Point(40, 46);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(43, 13);
            this.lblGastos.TabIndex = 12;
            this.lblGastos.Text = "Gastos:";
            this.lblGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGanhos
            // 
            this.txtGanhos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGanhos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtGanhos.Location = new System.Drawing.Point(89, 17);
            this.txtGanhos.Name = "txtGanhos";
            this.txtGanhos.ReadOnly = true;
            this.txtGanhos.Size = new System.Drawing.Size(168, 20);
            this.txtGanhos.TabIndex = 11;
            // 
            // lblGanhos
            // 
            this.lblGanhos.AutoSize = true;
            this.lblGanhos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGanhos.Location = new System.Drawing.Point(36, 20);
            this.lblGanhos.Name = "lblGanhos";
            this.lblGanhos.Size = new System.Drawing.Size(47, 13);
            this.lblGanhos.TabIndex = 10;
            this.lblGanhos.Text = "Ganhos:";
            this.lblGanhos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chtCategorias
            // 
            this.chtCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chtCategorias.BackColor = System.Drawing.Color.Gainsboro;
            this.chtCategorias.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.Name = "ChartArea1";
            this.chtCategorias.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtCategorias.Legends.Add(legend3);
            this.chtCategorias.Location = new System.Drawing.Point(12, 434);
            this.chtCategorias.Name = "chtCategorias";
            this.chtCategorias.Size = new System.Drawing.Size(407, 209);
            this.chtCategorias.TabIndex = 8;
            this.chtCategorias.Text = "chart1";
            // 
            // frmResumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 655);
            this.ControlBox = false;
            this.Controls.Add(this.chtCategorias);
            this.Controls.Add(this.grpTotais);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.lblResumo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(170, 0);
            this.Name = "frmResumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmResumo";
            this.Load += new System.EventHandler(this.frmResumo_Load);
            this.Resize += new System.EventHandler(this.frmResumo_Resize);
            this.grpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.grpTotais.ResumeLayout(false);
            this.grpTotais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker dtDateIn;
        private System.Windows.Forms.Label lblDateIn;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPaymentForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGanhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSaldo;
        private System.Windows.Forms.GroupBox grpTotais;
        private System.Windows.Forms.Label lblGanhos;
        private System.Windows.Forms.TextBox txtMeuSaldo;
        private System.Windows.Forms.Label lblMeuSaldo;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.TextBox txtGanhos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCategorias;
    }
}