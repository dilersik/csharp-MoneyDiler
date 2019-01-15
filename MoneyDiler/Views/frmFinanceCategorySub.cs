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
    public partial class frmFinanceCategorySub : Form
    {
        public frmFinanceCategorySub()
        {
            InitializeComponent();
        }

        private void frmFinanceCategorySub_Load(object sender, EventArgs e)
        {
            this.cmbType_Start();
            this.showGrid();
        }

        private void cmbType_Start()
        {
            foreach (string x in FinanceCategoryU.ArrayType)
            {
                cmbType.Items.Add(x);
                cmbBuscarType.Items.Add(x);
            }
        }

        private void showGrid()
        {
            FinanceCategory financeCategory = new FinanceCategory();
            FinanceCategorySub financeCategorySub = new FinanceCategorySub();

            if (cmbBuscarType.SelectedIndex != 0)
                financeCategory.Type = cmbBuscarType.SelectedIndex;
            if (cmbBuscarCategory.SelectedItem != null)
                financeCategory = (FinanceCategory)cmbBuscarCategory.SelectedItem;

            financeCategorySub.FinanceCategory = financeCategory;
            dgList.Rows.Clear();
            foreach (FinanceCategorySub x in FinanceCategorySubDAO.ListAllBy(financeCategorySub))
                dgList.Rows.Add(x.Id, x.Name, x.FinanceCategory.Name);
        }

        private bool validateForm(FinanceCategorySub financeCategorySub)
        {
            if (cmbType.SelectedIndex.Equals(0) || cmbType.Text.Trim().Equals(""))
            {
                lblErrorType.Text = "Campo obrigatório";
                cmbType.Focus();
                return false;
            }
            lblErrorType.Text = "";

            if (cmbCategory.SelectedItem == null)
            {
                lblErrorCategory.Text = "Campo obrigatório";
                cmbCategory.Focus();
                return false;
            }
            lblErrorCategory.Text = "";

            financeCategorySub.Name = txtName.Text.Trim();
            if (financeCategorySub.Name.Equals(""))
            {
                lblErrorName.Text = "Campo obrigatório.";
                txtName.Focus();
                return false;
            }
            if (FinanceCategorySubDAO.CountByName(financeCategorySub) > 0)
            {
                lblErrorName.Text = "Já consta cadastrado.";
                return false;
            }
            lblErrorName.Text = "";

            return true;
        }

        private void ClearFields()
        {
            cmbType.SelectedIndex = 0;
            lblErrorType.Text = "";
            cmbCategory.Items.Clear();
            lblErrorCategory.Text = "";
            txtName.Clear();
            lblErrorName.Text = "";
            txtId.Clear();
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            FinanceCategorySub financeCategorySub = new FinanceCategorySub();
            int Id;
            if (int.TryParse(txtId.Text, out Id))
            {
                financeCategorySub.Id = Id;
                financeCategorySub = FinanceCategorySubDAO.GetByID(financeCategorySub);
            }
            FinanceCategory financeCategory = new FinanceCategory();
            financeCategory = (FinanceCategory) cmbCategory.SelectedItem;
            financeCategory = FinanceCategoryDAO.GetByID(financeCategory);
            financeCategorySub.FinanceCategory = financeCategory;
            if (this.validateForm(financeCategorySub))
            {
                if (financeCategorySub.Id > 0)
                {
                    if (FinanceCategorySubDAO.Update(financeCategorySub))
                    {
                        MessageBox.Show("Alterado com sucesso.");
                        this.ClearFields();
                        this.showGrid();
                        return;
                    }
                    MessageBox.Show("Erro: Ocorreu um erro inesperado alterar.");
                }
                else
                {
                    if (FinanceCategorySubDAO.Insert(financeCategorySub))
                    {
                        MessageBox.Show("Cadastrado com sucesso.");
                        this.ClearFields();
                        this.showGrid();
                        return;
                    }
                    MessageBox.Show("Erro: Ocorreu um erro inesperado cadastrar.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ShowCmbCategory();
        }

        private void ShowCmbCategory()
        {
            FinanceCategory financeCategory = new FinanceCategory();
            financeCategory.Type = cmbType.SelectedIndex;

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Carregando ...");
            cmbCategory.Items.Clear();
            foreach (FinanceCategory x in FinanceCategoryDAO.ListByType(financeCategory))
                cmbCategory.Items.Add(x);

            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
        }

        private void cmbBuscarType_SelectedValueChanged(object sender, EventArgs e)
        {
            FinanceCategory financeCategory = new FinanceCategory();
            financeCategory.Type = cmbBuscarType.SelectedIndex;

            cmbBuscarCategory.Items.Clear();
            cmbBuscarCategory.Items.Add("Carregando ...");
            cmbBuscarCategory.Items.Clear();
            foreach (FinanceCategory x in FinanceCategoryDAO.ListByType(financeCategory))
                cmbBuscarCategory.Items.Add(x);

            cmbBuscarCategory.ValueMember = "Id";
            cmbBuscarCategory.DisplayMember = "Name";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.showGrid();
        }

        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            FinanceCategorySub financeCategorySubVO = new FinanceCategorySub();
            financeCategorySubVO.Id = int.Parse(dgList.CurrentRow.Cells["clId"].Value.ToString());
            financeCategorySubVO = FinanceCategorySubDAO.GetByID(financeCategorySubVO);
            cmbType.SelectedIndex = financeCategorySubVO.FinanceCategory.Type;
            this.ShowCmbCategory();
            cmbCategory.SelectedItem = financeCategorySubVO.FinanceCategory;
            txtName.Text = financeCategorySubVO.Name;
            txtId.Text = financeCategorySubVO.Id.ToString();

            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo este registro?", "Sub-Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FinanceCategorySub financeCategorySubVO = new FinanceCategorySub();
                financeCategorySubVO.Id = int.Parse(txtId.Text);
                financeCategorySubVO = FinanceCategorySubDAO.GetByID(financeCategorySubVO);
                if (!FinanceCategorySubDAO.UpdateDisable(financeCategorySubVO))
                    MessageBox.Show("Erro: Ocorreu um erro inesperado excluir.");
                else
                {
                    MessageBox.Show("Excluído com sucesso.");
                    this.ClearFields();
                    this.showGrid();
                }
            }
        }

    }
}
