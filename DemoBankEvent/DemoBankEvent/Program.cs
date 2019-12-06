using System;

namespace DemoBankEvent {
    class BankAccount {
        //private int acct_num;
        //private double balance;
        public event EventHandler BalanceAdjusted;
        public BankAccount(int acct) {
            AcctNum = acct;
            Balance = 0;
        }
        public int AcctNum { get; protected set; }
        public double Balance { get; protected set; }
        public void OnBalanceAdjusted(EventArgs e) {
            BalanceAdjusted(this, e);
        }
        public void MakeDeposit(double amt) {
            Balance += amt;
            OnBalanceAdjusted(EventArgs.Empty);
        }
        public void MakeWithdrawal(double amt) {
            Balance -= amt;
            OnBalanceAdjusted(EventArgs.Empty);
        }
    }
    class EventListener {
        private BankAccount acct;
        public EventListener(BankAccount account) {
            acct = account;
            acct.BalanceAdjusted += new EventHandler(BankAccountBalanceAdjusted);
        }
        private void BankAccountBalanceAdjusted(object sender, EventArgs e) {
            Console.WriteLine("The account balance has been adjusted.");
            Console.WriteLine(" Account # {0} balance {1}", acct.AcctNum, acct.Balance.ToString("C2"));
        }
    }
    class Program {
        static void Main(string[] args) {
            const int TRANSACTIONS = 5;
            char code;
            double amt;
            BankAccount acct = new BankAccount(334455);
            EventListener listener = new EventListener(acct);
            for (int x = 0; x < TRANSACTIONS; ++x) {
                Console.Write("Enter D for deposit or W for withdrawal ");
                code = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter dollar amount ");
                amt = Convert.ToDouble(Console.ReadLine());
                if (code == 'D') {
                    acct.MakeDeposit(amt);
                } else {
                    acct.MakeWithdrawal(amt);
                }
            }
        }
    }
}
