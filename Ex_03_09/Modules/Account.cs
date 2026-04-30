using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_09.Modules
{
    public class Account
    {
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public int Balance { get; set; }

        public Account(string AccountNo, string AccountName, int Balance)
        {
            this.AccountNo = AccountNo;
            this.AccountName = AccountName;
            this.Balance = Balance;
        }

        public virtual void Print()
        {
            Console.Write("口座番号：" + AccountNo + " ");
            Console.Write("口座名義：" + AccountName + " ");
            Console.Write("残高：" + Balance + " ");
        }

        public override string ToString()
        {
            return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
        }
    }
}