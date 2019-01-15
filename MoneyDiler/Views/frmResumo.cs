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
    public partial class frmResumo : Form
    {
        public frmResumo()
        {
            InitializeComponent();
        }

        private void frmResumo_Load(object sender, EventArgs e)
        {
            dtDateIn.Value = DateTime.Now.AddMonths(-1);
            this.showGrid();
            this.showChart();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.showGrid();
            this.showChart();
        }

        private void showGrid()
        {
            DateTime dateIn = DateTime.Parse(dtDateIn.Text);
            DateTime dateEnd = DateTime.Parse(dtDateEnd.Text);
            Finance finance;
            double ganhos, gastos, totalGanhos = 0, totalGastos = 0, saldo;

            dgList.Rows.Clear();
            foreach (PaymentForm p in PaymentFormDAO.ListAll())
            {
                finance = new Finance();
                finance.FinanceCategorySub = new FinanceCategorySub();
                finance.FinanceCategorySub.FinanceCategory = new FinanceCategory();
                finance.FinanceCategorySub.FinanceCategory.Type = FinanceCategoryU.TYPE_GANHO;
                finance.PaymentForm = p;
                ganhos = 0;
                foreach (Finance f in FinanceDAO.ListByFilter(finance, dateIn, dateEnd))
                    ganhos += f.Value;

                finance.FinanceCategorySub.FinanceCategory.Type = FinanceCategoryU.TYPE_GASTO;
                gastos = 0;
                foreach (Finance f in FinanceDAO.ListByFilter(finance, dateIn, dateEnd))
                    gastos += f.Value;

                dgList.Rows.Add(p.Name, Util.moneyFormat_ptBR(ganhos), Util.moneyFormat_ptBR(gastos), Util.moneyFormat_ptBR(FinanceBO.CalcSaldo(ganhos, gastos)));
                totalGanhos += ganhos;
                totalGastos += gastos;
            }

            txtGanhos.Text = Util.moneyFormat_ptBR(totalGanhos);
            txtGastos.Text = Util.moneyFormat_ptBR(totalGastos);
            saldo = FinanceBO.CalcSaldo(totalGanhos, totalGastos);
            txtMeuSaldo.Text = Util.moneyFormat_ptBR(saldo);
            if (saldo > 0)
                txtMeuSaldo.ForeColor = System.Drawing.Color.Green;
            else
                txtMeuSaldo.ForeColor = System.Drawing.Color.Red;
        }

        private void showChart()
        {
            DateTime dateIn = DateTime.Parse(dtDateIn.Text);
            DateTime dateEnd = DateTime.Parse(dtDateEnd.Text);
            bool check = false;
            double gastos = 0;
            int i = 1;

            for (int j = 0; j < chtCategorias.Series.Count; j++)
            {
                chtCategorias.Series.RemoveAt(j);
            }

            chtCategorias.Titles.Clear();
            chtCategorias.Titles.Add("Gastos no perído de " + dateIn.ToShortDateString() + " até " + dateEnd.ToShortDateString());
            
            FinanceCategory fc = new FinanceCategory();
            fc.Type = FinanceCategoryU.TYPE_GASTO;                        
            foreach (FinanceCategory x in FinanceCategoryDAO.ListFinanceByType(fc))
            {
                if (x.Status > 0)
                {
                    gastos = 0;
                    check = false;
                    foreach (FinanceCategorySub y in x.collFinanceCategorySub)
                    {
                        if (y.Status > 0)
                        {
                            foreach (Finance z in y.collFinance)
                            {
                                if (z.Status > 0 && 
                                    DateTime.Compare(z.Date, dateIn) >= 0 && 
                                    DateTime.Compare(z.Date, dateEnd) <= 0)
                                {
                                    gastos += z.Value;
                                    check = true;
                                }
                            }
                        }
                    }
                }

                if (check)
                {
                    if (chtCategorias.Series.IsUniqueName("s" + x.Id))
                        chtCategorias.Series.Add("s" + x.Id);
                    chtCategorias.Series["s" + x.Id].LegendText = x.Name;
                    chtCategorias.Series["s" + x.Id].Points.AddXY(i, gastos);
                    i++;
                }
            }

            chtCategorias.Update();
        }

        private void frmResumo_Resize(object sender, EventArgs e)
        {
            chtCategorias.Width = this.Width - grpTotais.Width - 30;
        }

        private void SetMinMaxDateRange()
        {
            dtDateIn.MaxDate = DateTime.Parse(dtDateEnd.Text).AddDays(-1);
            dtDateEnd.MinDate = DateTime.Parse(dtDateIn.Text).AddDays(1);
        }

        private void dtDateIn_ValueChanged(object sender, EventArgs e)
        {
            this.SetMinMaxDateRange();
        }

        private void dtDateEnd_ValueChanged(object sender, EventArgs e)
        {
            this.SetMinMaxDateRange();
        }

    }
}
