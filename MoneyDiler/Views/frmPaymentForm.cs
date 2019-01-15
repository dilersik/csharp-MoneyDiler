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
    public partial class frmPaymentForm : Form
    {
        public frmPaymentForm()
        {
            InitializeComponent();
        }

        private void frmPaymentForm_Load(object sender, EventArgs e)
        {
            this.cmbType_Start();
            this.showGrid();
        }

        private void cmbType_Start()
        {
            foreach (string x in PaymentFormU.ArrayType)
            {
                cmbType.Items.Add(x);
            }
        }

        private void showGrid()
        {
            dgList.Rows.Clear();
            foreach (PaymentForm x in PaymentFormDAO.ListAll())
                dgList.Rows.Add(x.Id, x.Name, PaymentFormU.ArrayType[x.Type], Util.moneyFormat_ptBR(x.InitialBalance));
        }

        private bool validateForm(PaymentForm paymentFormVO)
        {
            paymentFormVO.Name = txtName.Text.Trim();
            if (paymentFormVO.Name.Equals(""))
            {
                lblErrorName.Text = "Campo obrigatório.";
                txtName.Focus();
                return false;
            }
            if (PaymentFormDAO.CountByName(paymentFormVO) > 0)
            {
                lblErrorName.Text = "Já consta cadastrado.";
                return false;
            }
            lblErrorName.Text = "";

            paymentFormVO.Type = cmbType.SelectedIndex;
            if (paymentFormVO.Type.Equals(0) || cmbType.Text.Trim().Equals(""))
            {
                lblErrorType.Text = "Campo obrigatório";
                cmbType.Focus();
                return false;
            }
            lblErrorType.Text = "";

            if (txtInitialBalance.Text.Trim().Equals(""))
            {
                lblErrorInitialBalance.Text = "Campo obrigatório.";
                txtInitialBalance.Focus();
                return false;
            }
            double initialBalance;
            if (!double.TryParse(txtInitialBalance.Text, out initialBalance))
            {
                lblErrorInitialBalance.Text = "Preencha um número válido.";
                return false;
            }
            lblErrorInitialBalance.Text = "";
            paymentFormVO.InitialBalance = initialBalance;
            
            return true;
        }

        private void ClearFields()
        {
            txtName.Clear();
            lblErrorName.Text = "";
            cmbType.SelectedIndex = 0;
            lblErrorType.Text = "";
            txtInitialBalance.Clear();
            lblInitialBalance.Text = "";
            txtId.Clear();
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PaymentForm paymentFormVO = new PaymentForm();
            int Id;
            if (int.TryParse(txtId.Text, out Id))
            {
                paymentFormVO.Id = Id;
                paymentFormVO = PaymentFormDAO.GetByID(paymentFormVO);
            }
            if (this.validateForm(paymentFormVO))
            {
                if (paymentFormVO.Id > 0)
                {
                    if (PaymentFormDAO.Update(paymentFormVO))
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
                    if (PaymentFormDAO.Insert(paymentFormVO))
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
            PaymentForm paymentFormVO = new PaymentForm();
            paymentFormVO.Id = int.Parse(dgList.CurrentRow.Cells["clId"].Value.ToString());
            paymentFormVO = PaymentFormDAO.GetByID(paymentFormVO);
            txtName.Text = paymentFormVO.Name;
            cmbType.SelectedIndex = paymentFormVO.Type;
            txtInitialBalance.Text = paymentFormVO.InitialBalance.ToString();
            txtId.Text = paymentFormVO.Id.ToString();

            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo este registro?", "Forma de Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PaymentForm paymentFormVO = new PaymentForm();
                paymentFormVO.Id = int.Parse(txtId.Text);
                paymentFormVO = PaymentFormDAO.GetByID(paymentFormVO);
                if (!PaymentFormDAO.UpdateDisable(paymentFormVO))
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
