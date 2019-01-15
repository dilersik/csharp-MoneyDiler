using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoneyDiler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDefault());
        }
    }
    /*class Program
    {

        static void Main(string[] args)
        {

            int opc, opcSub;
            string[] menu = { "Sair", "Formas de Pagamento", "Categorias de Financas", "Sub-Categorias de Financas", "Financas"};

            opc = Util.Menu("Menu Principal - Calculo de Bagaca", menu);

            do
            {
                switch (opc)
                {
                    case 1: 
                        string[] menuSub1 = { "Voltar", "Insert", "Update", "Delete", "List" };
                        opcSub = Util.Menu("\nMenu Formas de Pagamento", menuSub1);
                        do
                        {
                            switch (opcSub)
                            {
                                case 1: AddFormaPagamento(); break;
                                case 2: EditFormaPagamento(); break;
                                case 3: DisableFormaPagamento(); break;
                                case 4: ListarFormaPagamento(); break;
                            }
                            opcSub = Util.Menu("\nMenu Formas de Pagamento", menuSub1);
                        } while (opcSub != 0);
                        break;

                    case 2:
                        string[] menuSub2 = { "Voltar", "Insert", "Update", "Delete", "List" };
                        opcSub = Util.Menu("\nCategorias de Financas", menuSub2);
                        do
                        {
                            switch (opcSub)
                            {
                                case 1: AddFinanceCat(); break;
                                case 2: EditFinanceCat(); break;
                                case 3: DisableFinanceCat(); break;
                                case 4: ListarFinanceCat(); break;
                            }
                            opcSub = Util.Menu("\nCategorias de Financas", menuSub2);
                        } while (opcSub != 0);
                        break;

                    case 3:
                        string[] menuSub3 = { "Voltar", "Insert", "Update", "Delete", "List" };
                        opcSub = Util.Menu("\nSubCategorias de Financas", menuSub3);
                        do
                        {
                            switch (opcSub)
                            {
                                case 1: AddFinanceCatSub(); break;
                                case 2: EditFinanceCatSub(); break;
                                case 3: DisableFinanceCatSub(); break;
                                case 4: ListarFinanceCatSub(); break;
                            }
                            opcSub = Util.Menu("\nSubCategorias de Financas", menuSub3);
                        } while (opcSub != 0);
                        break;

                    case 4:
                        string[] menuSub4 = { "Voltar", "Insert" };
                        opcSub = Util.Menu("\nFinancas", menuSub4);
                        do
                        {
                            switch (opcSub)
                            {
                                case 1: AddFinance(); break;
                            }
                            opcSub = Util.Menu("\nFinancas", menuSub4);
                        } while (opcSub != 0);
                        break;

                    default: Environment.Exit(0); break;
                }
                opc = Util.Menu("\nMenu Principal - Calculo de Bagaca", menu);
            } while (opc != 0);

        }

        private static void AddFormaPagamento()
        {
            PaymentForm paymentFormVO = new PaymentForm();
            Console.Write("Nome: ");
            paymentFormVO.Name = Console.ReadLine();

            if (PaymentFormDAO.CountByName(paymentFormVO) == 1)
            {
                Console.Clear();
                Console.WriteLine("Erro: ja consta cadastrado.");
                return;
            }
            Console.Write("Tipo (1 CC, 2 CP, 3 Outros) :");
            paymentFormVO.Type = int.Parse(Console.ReadLine());
            Console.Write("Saldo inicial: R$ ");
            paymentFormVO.InitialBalance = double.Parse(Console.ReadLine());

            if (PaymentFormDAO.Insert(paymentFormVO))
                Console.WriteLine("Cadastrado com sucesso.");
            else
                Console.WriteLine("Erro: Bixeira.");
        }

        private static void EditFormaPagamento()
        {
            PaymentForm paymentFormVO = new PaymentForm();
            Console.Write("ID: ");
            paymentFormVO.Id = int.Parse(Console.ReadLine());

            paymentFormVO = PaymentFormDAO.GetByID(paymentFormVO);
            if (paymentFormVO == null)
            {
                Console.Clear();
                Console.WriteLine("Erro: nao consta cadastrado.");
                return ;
            }
            Console.Write("Nome (" + paymentFormVO.Name + "): ");
            paymentFormVO.Name = Console.ReadLine();

            if (PaymentFormDAO.CountByName(paymentFormVO) == 1)
            {
                Console.Clear();
                Console.WriteLine("Erro: ja consta cadastrado.");
                return ;
            }
            Console.Write("Tipo (" + PaymentForm.ArrayType[paymentFormVO.Type] + "): ");
            paymentFormVO.Type = int.Parse(Console.ReadLine());
            Console.Write("Saldo inicial: R$ ");
            paymentFormVO.InitialBalance = double.Parse(Console.ReadLine());

            if (PaymentFormDAO.Update(paymentFormVO))
                Console.WriteLine("Alterado com sucesso.");
            else
                Console.WriteLine("Erro: Bixeira.");
        }

        private static void DisableFormaPagamento()
        {
            PaymentForm paymentFormVO = new PaymentForm();
            Console.Write("ID: ");
            paymentFormVO.Id = int.Parse(Console.ReadLine());

            paymentFormVO = PaymentFormDAO.GetByID(paymentFormVO);
            if (paymentFormVO == null)
            {
                Console.Clear();
                Console.WriteLine("Erro: nao consta cadastrado.");
                return;
            }
            Console.Write("Deseja excluir (" + paymentFormVO.Name + ") N / S? ");
            string check = Console.ReadLine();
            if (check.Equals("s"))
            {
                if (PaymentFormDAO.UpdateDisable(paymentFormVO))
                    Console.WriteLine("Excluido com sucesso.");
                else
                    Console.WriteLine("Erro: Bixeira.");
            }
        }

        private static void ListarFormaPagamento()
        {
            foreach (PaymentForm x in PaymentFormDAO.ListAll())
            {
                Console.WriteLine("ID: " + x.Id);
                Console.WriteLine("Data post: " + x.DatePost);
                Console.WriteLine("Data update: " + x.DateUpdate);
                Console.WriteLine("Tipo: " + PaymentForm.ArrayType[x.Type]);
                Console.WriteLine("Saldo Incial: " + x.InitialBalance.ToString("N2"));
                Console.WriteLine("Nome: " + x.Name + "\n");
            }
        }

        private static void AddFinanceCat()
        {
            FinanceCategory financeCategoryVO = new FinanceCategory();
            Console.Write("Tipo (1 GANHO, 2 GASTO): ");
            financeCategoryVO.Type = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            financeCategoryVO.Name = Console.ReadLine();

            if (FinanceCategoryDAO.CountByName(financeCategoryVO) == 1)
            {
                Console.Clear();
                Console.WriteLine("Erro: ja consta cadastrado.");
                return ;
            }
            if (FinanceCategoryDAO.Insert(financeCategoryVO))
                Console.WriteLine("Cadastrado com sucesso.");
            else
                Console.WriteLine("Erro: Bixeira.");
        }

        private static void EditFinanceCat()
        {
            FinanceCategory financeCategoryVO = new FinanceCategory();
            Console.Write("ID: ");
            financeCategoryVO.Id = int.Parse(Console.ReadLine());

            financeCategoryVO = FinanceCategoryDAO.GetByID(financeCategoryVO);
            if (financeCategoryVO == null)
            {
                Console.Clear();
                Console.WriteLine("Erro: Nao consta cadastrado.");
                return;
            }
            Console.Write("Tipo (" + FinanceCategory.ArrayType[financeCategoryVO.Type] + "): ");
            financeCategoryVO.Type = int.Parse(Console.ReadLine());
            Console.Write("Nome (" + financeCategoryVO.Name + "): ");
            financeCategoryVO.Name = Console.ReadLine();

            if (FinanceCategoryDAO.CountByName(financeCategoryVO) == 1)
            {
                Console.Clear();
                Console.WriteLine("Erro: ja consta cadastrado.");
                return;
            }

            if (FinanceCategoryDAO.Update(financeCategoryVO))
                Console.WriteLine("Alterado com sucesso.");
            else
                Console.WriteLine("Erro: Bixeira.");
        }

        private static void DisableFinanceCat()
        {
            FinanceCategory financeCategoryVO = new FinanceCategory();
            Console.Write("ID: ");
            financeCategoryVO.Id = int.Parse(Console.ReadLine());

            financeCategoryVO = FinanceCategoryDAO.GetByID(financeCategoryVO);
            if (financeCategoryVO == null)
            {
                Console.Clear();
                Console.WriteLine("Erro: nao consta cadastrado.");
                return;
            }
            Console.Write("Deseja excluir (" + financeCategoryVO.Name + ") N / S? ");
            string check = Console.ReadLine().ToLower();
            if (check.Equals("s"))
            {
                if (FinanceCategoryDAO.UpdateDisable(financeCategoryVO))
                    Console.WriteLine("Excluido com sucesso.");
                else
                    Console.WriteLine("Erro: Bixeira.");
            }
        }

        private static void ListarFinanceCat()
        {
            FinanceCategory financeCategoryVO = new FinanceCategory();
            Console.Write("Tipo (1 GANHO, 2 GASTO): ");
            financeCategoryVO.Type = int.Parse(Console.ReadLine());
            foreach (FinanceCategory x in FinanceCategoryDAO.ListAll(financeCategoryVO))
            {
                Console.WriteLine("ID: " + x.Id);
                Console.WriteLine("Data post: " + x.DatePost);
                Console.WriteLine("Data update: " + x.DateUpdate);
                Console.WriteLine("Nome: " + x.Name + "\n");
            }
        }

        private static void AddFinanceCatSub()
        {
            FinanceCategorySub financeCategorySubVO = new FinanceCategorySub();
            FinanceCategory financeCategoryVO = new FinanceCategory();

            Console.Write("Categoria ID (Select Cat): ");
            financeCategoryVO.Id = int.Parse(Console.ReadLine());
            financeCategoryVO = FinanceCategoryDAO.GetByID(financeCategoryVO);
            financeCategorySubVO.FinanceCategory = financeCategoryVO;
            Console.Write("Nome: ");
            financeCategorySubVO.Name = Console.ReadLine();

            if (FinanceCategorySubDAO.CountByName(financeCategorySubVO) == 1)
            {
                Console.Clear();
                Console.WriteLine("Erro: ja consta cadastrado.");
                return;
            }
            if (FinanceCategorySubDAO.Insert(financeCategorySubVO))
                Console.WriteLine("Cadastrado com sucesso.");
            else
                Console.WriteLine("Erro: Bixeira.");
        }

        private static void EditFinanceCatSub()
        {
            FinanceCategorySub financeCategorySubVO = new FinanceCategorySub();
            Console.Write("ID: ");
            financeCategorySubVO.Id = int.Parse(Console.ReadLine());

            financeCategorySubVO = FinanceCategorySubDAO.GetByID(financeCategorySubVO);
            if (financeCategorySubVO == null)
            {
                Console.Clear();
                Console.WriteLine("Erro: Nao consta cadastrado.");
                return;
            }
            FinanceCategory financeCategoryVO = new FinanceCategory();

            Console.Write("Categoria ID (Select Cat): ");
            financeCategoryVO.Id = int.Parse(Console.ReadLine());
            financeCategoryVO = FinanceCategoryDAO.GetByID(financeCategoryVO);
            financeCategorySubVO.FinanceCategory = financeCategoryVO;
            Console.Write("Nome (" + financeCategorySubVO.Name + "): ");
            financeCategorySubVO.Name = Console.ReadLine();

            if (FinanceCategorySubDAO.CountByName(financeCategorySubVO) == 1)
            {
                Console.Clear();
                Console.WriteLine("Erro: ja consta cadastrado.");
                return;
            }

            if (FinanceCategorySubDAO.Update(financeCategorySubVO))
                Console.WriteLine("Alterado com sucesso.");
            else
                Console.WriteLine("Erro: Bixeira.");
        }

        private static void DisableFinanceCatSub()
        {
            FinanceCategorySub financeCategorySubVO = new FinanceCategorySub();
            Console.Write("ID: ");
            financeCategorySubVO.Id = int.Parse(Console.ReadLine());

            financeCategorySubVO = FinanceCategorySubDAO.GetByID(financeCategorySubVO);
            if (financeCategorySubVO == null)
            {
                Console.Clear();
                Console.WriteLine("Erro: nao consta cadastrado.");
                return;
            }
            Console.Write("Deseja excluir (" + financeCategorySubVO.Name + ") N / S? ");
            string check = Console.ReadLine().ToLower();
            if (check.Equals("s"))
            {
                if (FinanceCategorySubDAO.UpdateDisable(financeCategorySubVO))
                    Console.WriteLine("Excluido com sucesso.");
                else
                    Console.WriteLine("Erro: Bixeira.");
            }
        }

        private static void ListarFinanceCatSub()
        {
            FinanceCategory financeCategoryVO = new FinanceCategory();
            FinanceCategorySub financeCategorySubVO = new FinanceCategorySub();

            Console.Write("Categoria ID (Select Cat): ");
            financeCategoryVO.Id = int.Parse(Console.ReadLine());
            financeCategoryVO = FinanceCategoryDAO.GetByID(financeCategoryVO);
            financeCategorySubVO.FinanceCategory = financeCategoryVO;
            foreach (FinanceCategorySub x in FinanceCategorySubDAO.ListAll(financeCategorySubVO))
            {
                Console.WriteLine("ID: " + x.Id);
                Console.WriteLine("Data post: " + x.DatePost);
                Console.WriteLine("Data update: " + x.DateUpdate);
                Console.WriteLine("Nome: " + x.Name + "\n");
            }
        }

        private static void AddFinance()
        {
            Finance financeVO = new Finance();

            FinanceCategorySub financeCategorySubVO = new FinanceCategorySub();
            Console.Write("Sub-Categoria ID (Select Cat and SubCat): ");
            financeCategorySubVO.Id = int.Parse(Console.ReadLine());
            financeCategorySubVO = FinanceCategorySubDAO.GetByID(financeCategorySubVO);

            financeVO.FinanceCategorySub = financeCategorySubVO;

            PaymentForm paymentFormVO = new PaymentForm();
            Console.Write("Forma Pgto ID (Select): ");
            paymentFormVO.Id = int.Parse(Console.ReadLine());
            paymentFormVO = PaymentFormDAO.GetByID(paymentFormVO);

            financeVO.PaymentForm = paymentFormVO;

            Console.Write("Data/Hora (DatePicker): ");
            financeVO.Date = DateTime.Parse(Console.ReadLine());

            Console.Write("Situação (Select Pg, Pendente): ");
            financeVO.Situation = int.Parse(Console.ReadLine());

            if (financeVO.Situation.Equals(FinanceBO.SITUATION_PAGO))
                financeVO.DateClose = financeVO.Date;
            else
                financeVO.DateClose = DateTime.Now;

            Console.Write("Repetição (Select Nao, ...): ");
            financeVO.Repeat = int.Parse(Console.ReadLine());

            Console.Write("Vezes de Repetição: ");
            financeVO.RepeatQtd = int.Parse(Console.ReadLine());

            Console.Write("Prioridade (Select 1,2,3): ");
            financeVO.Priority = int.Parse(Console.ReadLine());

            Console.Write("Descrição: ");
            financeVO.Text = Console.ReadLine();

            bool retorn = false;
            for (int x = 0; x < financeVO.RepeatQtd; x++)
            {
                if (FinanceDAO.Insert(financeVO))
                    retorn = true;
            }

            if (retorn)
                Console.WriteLine("Cadastrado com sucesso.");
            else
                Console.WriteLine("Erro: Bixeira.");
        }

    }*/
}
