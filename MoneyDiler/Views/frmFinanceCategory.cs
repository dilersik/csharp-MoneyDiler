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
    public partial class frmFinanceCategory : Form
    {
        public frmFinanceCategory()
        {
            InitializeComponent();
        }

        private void frmFinanceCategory_Load(object sender, EventArgs e)
        {
            this.cmbType_Start();
            this.showGrid();
        }

        private void cmbType_Start()
        {
            foreach (string x in FinanceCategoryU.ArrayType)
            {
                cmbType.Items.Add(x);
            }
        }

        private void showGrid()
        {
            dgList.Rows.Clear();
            foreach (FinanceCategory x in FinanceCategoryDAO.ListAll())
                dgList.Rows.Add(x.Id, x.Name, FinanceCategoryU.ArrayType[x.Type]);
        }

        private bool validateForm(FinanceCategory financeCategory)
        {
            financeCategory.Type = cmbType.SelectedIndex;
            if (financeCategory.Type.Equals(0) || cmbType.Text.Trim().Equals(""))
            {
                lblErrorType.Text = "Campo obrigatório";
                cmbType.Focus();
                return false;
            }
            lblErrorType.Text = "";

            financeCategory.Name = txtName.Text.Trim();
            if (financeCategory.Name.Equals(""))
            {
                lblErrorName.Text = "Campo obrigatório.";
                txtName.Focus();
                return false;
            }
            if (FinanceCategoryDAO.CountByName(financeCategory) > 0)
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
            txtName.Clear();
            lblErrorName.Text = "";
            txtId.Clear();
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FinanceCategory financeCategory = new FinanceCategory();
            int Id;
            if (int.TryParse(txtId.Text, out Id))
            {
                financeCategory.Id = Id;
                financeCategory = FinanceCategoryDAO.GetByID(financeCategory);
            }
            if (this.validateForm(financeCategory))
            {
                if (financeCategory.Id > 0)
                {
                    if (FinanceCategoryDAO.Update(financeCategory))
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
                    if (FinanceCategoryDAO.Insert(financeCategory))
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

        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            FinanceCategory financeCategoryVO = new FinanceCategory();
            financeCategoryVO.Id = int.Parse(dgList.CurrentRow.Cells["clId"].Value.ToString());
            financeCategoryVO = FinanceCategoryDAO.GetByID(financeCategoryVO);
            cmbType.SelectedIndex = financeCategoryVO.Type;
            txtName.Text = financeCategoryVO.Name;
            txtId.Text = financeCategoryVO.Id.ToString();

            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo este registro?", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FinanceCategory financeCategoryVO = new FinanceCategory();
                financeCategoryVO.Id = int.Parse(txtId.Text);
                financeCategoryVO = FinanceCategoryDAO.GetByID(financeCategoryVO);
                if (!FinanceCategoryDAO.UpdateDisable(financeCategoryVO))
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
