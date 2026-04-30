using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_08.Modules
{
    public class Account
    {
        public string? AccountNo { get; set; }
        /// 口座番号を表すプロパティ
        public string? AccountName { get; set; }
        /// 口座名義を表すプロパティ

        public int Balance { get; set; }
        ///残高を表すプロパティ
    }
}