using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoneyDiler
{
    public partial class frmDefault : Form
    {
        public frmDefault()
        {
            InitializeComponent();
        }

        private void frmDefault_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.ShowResumo();
        }

        private void btnFormasPgto_Click(object sender, EventArgs e)
        {
            this.EnableButtons();
            btnFormasPgto.Enabled = false;

            frmPaymentForm frmPaymentForm = new frmPaymentForm();
            frmPaymentForm.MdiParent = this;
            this.ResizeMdiChildren();
            frmPaymentForm.Show();
        }

        private void ResizeMdiChildren()
        {
            int newWidth = this.Width - 200;
            int newHeight = this.Height - 200;
            foreach (Form formFilho in this.MdiChildren)
            {
                formFilho.Width = newWidth;
                formFilho.Height = newHeight;
            }
        }

        private void frmDefault_Resize(object sender, EventArgs e)
        {
            this.ResizeMdiChildren();
        }

        private void EnableButtons()
        {
            btnResumo.Enabled = true;
            btnGanhos.Enabled = true;
            btnGastos.Enabled = true;
            btnCategorias.Enabled = true;
            btnSubCategorias.Enabled = true;
            btnFormasPgto.Enabled = true;
        }

        private void DisableForms()
        {
            foreach (Form formFilho in this.MdiChildren)
            {
                formFilho.Close();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            this.DisableForms();
            this.EnableButtons();
            btnCategorias.Enabled = false;

            frmFinanceCategory frmFinanceCategory = new frmFinanceCategory();
            frmFinanceCategory.MdiParent = this;
            this.ResizeMdiChildren();
            frmFinanceCategory.Show();
        }

        private void btnSubCategorias_Click(object sender, EventArgs e)
        {
            this.DisableForms();
            this.EnableButtons();
            btnSubCategorias.Enabled = false;

            frmFinanceCategorySub frmFinanceCategorySub = new frmFinanceCategorySub();
            frmFinanceCategorySub.MdiParent = this;
            this.ResizeMdiChildren();
            frmFinanceCategorySub.Show();
        }

        private void btnGanhos_Click(object sender, EventArgs e)
        {
            this.DisableForms();
            this.EnableButtons();
            btnGanhos.Enabled = false;

            frmFinance frmFinance = new frmFinance();
            frmFinance.MdiParent = this;
            frmFinance.Type = FinanceCategoryU.TYPE_GANHO;
            this.ResizeMdiChildren();
            frmFinance.Show();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            this.DisableForms();
            this.EnableButtons();
            btnGastos.Enabled = false;

            frmFinance frmFinance = new frmFinance();
            frmFinance.MdiParent = this;
            frmFinance.Type = FinanceCategoryU.TYPE_GASTO;
            this.ResizeMdiChildren();
            frmFinance.Show();
        }

        private void ShowResumo()
        {
            this.DisableForms();
            this.EnableButtons();
            btnResumo.Enabled = false;

            frmResumo frmResumo = new frmResumo();
            frmResumo.MdiParent = this;
            this.ResizeMdiChildren();
            frmResumo.Show();
        }

        private void btnResumo_Click(object sender, EventArgs e)
        {
            this.ShowResumo();
        }

    }
}
