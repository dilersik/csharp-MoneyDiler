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
    public partial class frmFinance : Form
    {
        public int Type { get; set; }

        public frmFinance()
        {
            InitializeComponent();
        }

        private void frmFinance_Load(object sender, EventArgs e)
        {
            this.cmbCategory_Start();
            this.cmbPaymentForm_Start();
            this.cmbPriority_Start();
            this.showGrid();
        }

        private void cmbCategory_Start()
        {
            FinanceCategory fc = new FinanceCategory();
            cmbCategory.Items.Add(fc);
            fc.Type = this.Type;
            foreach (FinanceCategory x in FinanceCategoryDAO.ListByType(fc))
            {
                cmbCategory.Items.Add(x);
                cmbBuscarCategory.Items.Add(x);
            }

            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
            cmbBuscarCategory.ValueMember = "Id";
            cmbBuscarCategory.DisplayMember = "Name";
        }

        private void cmbPaymentForm_Start()
        {
            PaymentForm pf = new PaymentForm();
            cmbPaymentForm.Items.Add(pf);
            foreach (PaymentForm x in PaymentFormDAO.ListAll())
                cmbPaymentForm.Items.Add(x);

            cmbPaymentForm.ValueMember = "Id";
            cmbPaymentForm.DisplayMember = "Name";
        }

        private void cmbPriority_Start()
        {
            foreach (string x in FinanceU.ArrayPriority)
                cmbPriority.Items.Add(x);
            cmbPriority.SelectedIndex = 1;
        }

        private void ShowCmbCategorySub()
        {
            FinanceCategorySub fcSub = new FinanceCategorySub();
            fcSub.FinanceCategory = (FinanceCategory)cmbCategory.SelectedItem;
            if (cmbCategory.SelectedItem == null)
                return;

            cmbCategorySub.Items.Clear();
            cmbCategorySub.Items.Add("Carregando ...");
            cmbCategorySub.Items.Clear();
            foreach (FinanceCategorySub x in FinanceCategorySubDAO.ListAllBy(fcSub))
                cmbCategorySub.Items.Add(x);

            cmbCategorySub.ValueMember = "Id";
            cmbCategorySub.DisplayMember = "Name";
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ShowCmbCategorySub();
        }

        private bool validateForm(Finance finance)
        {
            if (cmbCategory.SelectedItem == null)
            {
                lblErrorCategory.Text = "Campo obrigatório";
                cmbCategory.Focus();
                return false;
            }
            lblErrorCategory.Text = "";

            if (cmbCategorySub.SelectedItem == null)
            {
                lblErrorCategorySub.Text = "Campo obrigatório";
                cmbCategorySub.Focus();
                return false;
            }
            lblErrorCategorySub.Text = "";

            if (cmbPaymentForm.SelectedItem == null)
            {
                lblErrorPaymentForm.Text = "Campo obrigatório";
                cmbPaymentForm.Focus();
                return false;
            }
            lblErrorPaymentForm.Text = "";

            if (txtValue.Text.Trim().Equals(""))
            {
                lblErrorValue.Text = "Campo obrigatório.";
                txtValue.Focus();
                return false;
            }
            double value;
            if (!double.TryParse(txtValue.Text, out value))
            {
                lblErrorValue.Text = "Preencha um número válido.";
                return false;
            }
            if (value < 0.01)
            {
                lblErrorValue.Text = "Valor mínimo de R$ 0,01.";
                return false;
            }
            lblErrorValue.Text = "";
            finance.Value = value;

            finance.Priority = cmbPriority.SelectedIndex;
            if (finance.Priority.Equals(0) || cmbPriority.Text.Trim().Equals(""))
            {
                lblErrorPriority.Text = "Campo obrigatório";
                cmbPriority.Focus();
                return false;
            }
            lblErrorPriority.Text = "";

            return true;
        }

        private void ClearFields()
        {
            cmbCategory.SelectedIndex = 0;
            lblErrorCategory.Text = "";
            cmbCategorySub.Items.Clear();
            lblErrorCategorySub.Text = "";
            cmbPaymentForm.SelectedIndex = 0;
            lblErrorPaymentForm.Text = "";
            txtValue.Clear();
            lblErrorValue.Text = "";
            cmbPriority.SelectedIndex = 0;
            lblErrorPriority.Text = "";
            txtText.Clear();
            txtId.Clear();
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();
            int Id;
            if (int.TryParse(txtId.Text, out Id))
            {
                finance.Id = Id;
                finance = FinanceDAO.GetByID(finance);
            }
            FinanceCategorySub financeCategorySub = new FinanceCategorySub();
            financeCategorySub = (FinanceCategorySub)cmbCategorySub.SelectedItem;
            financeCategorySub = FinanceCategorySubDAO.GetByID(financeCategorySub);
            finance.FinanceCategorySub = financeCategorySub;

            PaymentForm paymentForm = new PaymentForm();
            paymentForm = (PaymentForm)cmbPaymentForm.SelectedItem;
            paymentForm = PaymentFormDAO.GetByID(paymentForm);
            finance.PaymentForm = paymentForm;

            finance.Date = dtDateTime.Value;
            if (rbSituationPago.Checked)
            {
                finance.Situation = FinanceU.SITUATION_PAGO;
                finance.DateClose = finance.Date;
            }
            else
            {
                finance.Situation = FinanceU.SITUATION_PENDENTE;
                finance.DateClose = DateTime.Now;
            }
            finance.Text = txtText.Text;

            if (this.validateForm(finance))
            {
                if (finance.Id > 0)
                {
                    if (FinanceDAO.Update(finance))
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
                    if (FinanceDAO.Insert(finance))
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

        private void cmbBuscarCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            FinanceCategorySub fcSub = new FinanceCategorySub();
            fcSub.FinanceCategory = (FinanceCategory)cmbBuscarCategory.SelectedItem;
            if (fcSub.FinanceCategory == null)
                return;

            cmbBuscarCategorySub.Items.Clear();
            cmbBuscarCategorySub.Items.Add("Carregando ...");
            cmbBuscarCategorySub.Items.Clear();
            foreach (FinanceCategorySub x in FinanceCategorySubDAO.ListAllBy(fcSub))
                cmbBuscarCategorySub.Items.Add(x);

            cmbBuscarCategorySub.ValueMember = "Id";
            cmbBuscarCategorySub.DisplayMember = "Name";
        }

        private void showGrid()
        {
            FinanceCategory financeCategory = new FinanceCategory();
            FinanceCategorySub financeCategorySub = new FinanceCategorySub();
            Finance finance = new Finance();

            if (cmbBuscarCategory.SelectedItem != null)
                financeCategory = (FinanceCategory)cmbBuscarCategory.SelectedItem;
            if (cmbBuscarCategorySub.SelectedItem != null)
                financeCategorySub = (FinanceCategorySub)cmbBuscarCategorySub.SelectedItem;

            financeCategory.Type = this.Type;
            finance.FinanceCategorySub = financeCategorySub;
            finance.FinanceCategorySub.FinanceCategory = financeCategory;
            dgList.Rows.Clear();
            foreach (Finance x in FinanceDAO.ListAllBy(finance))
                dgList.Rows.Add(x.Id, x.FinanceCategorySub.FinanceCategory.Name + ", " + x.FinanceCategorySub.Name,
                                Util.moneyFormat_ptBR(x.Value), x.Date, FinanceU.ArraySituation[x.Situation], 
                                x.PaymentForm.Name, FinanceU.ArrayPriority[x.Priority]);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.showGrid();
        }
        
        private void dgList_DoubleClick(object sender, EventArgs e)
        {
            Finance financeVO = new Finance();
            financeVO.Id = int.Parse(dgList.CurrentRow.Cells["clId"].Value.ToString());
            financeVO = FinanceDAO.GetByID(financeVO);
            cmbCategory.SelectedItem = financeVO.FinanceCategorySub.FinanceCategory;
            this.ShowCmbCategorySub();
            cmbCategorySub.SelectedItem = financeVO.FinanceCategorySub;
            cmbPaymentForm.SelectedItem = financeVO.PaymentForm;
            txtValue.Text = financeVO.Value.ToString();
            dtDateTime.Text = financeVO.Date.ToString();
            if (financeVO.Situation == FinanceU.SITUATION_PAGO)
                rbSituationPago.Checked = true;
            else
                rbSituationPendente.Checked = true;
            cmbPriority.SelectedIndex = financeVO.Priority;
            txtText.Text = financeVO.Text;
            txtId.Text = financeVO.Id.ToString();

            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo este registro?", "Finança", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Finance financeVO = new Finance();
                financeVO.Id = int.Parse(txtId.Text);
                financeVO = FinanceDAO.GetByID(financeVO);
                if (!FinanceDAO.UpdateDisable(financeVO))
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
