using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_09.Modules
{
    public class Account
    {
        private string? AccountNo { get; set; }
        private string? AccountName { get; set; }
        private int Balance { get; set; }

        public Account(string AccountNo, string AccountName, int Balance)
        {
            this.AccountNo = AccountNo;
            this.AccountName = AccountName;
            this.Balance = Balance;
        }

        public virtual void Print()
        {
            Console.WriteLine("口座番号：" + AccountNo + " ");
            Console.WriteLine("口座名義：" + AccountName + " ");
            Console.WriteLine("残高：" + Balance + " ");
        }

        public override string ToString()
        {
            return $"Account[AccountNo = {AccountNo},AccountName = {AccountName},Balance = {Balance}]";
        }
    }
}