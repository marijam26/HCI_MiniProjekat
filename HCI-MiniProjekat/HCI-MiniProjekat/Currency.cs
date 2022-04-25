using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_MiniProjekat
{
    internal class Currency
    {
        private String currency_code{get;set;}

        private String currency_name{get;set;}

        public Currency(String currency_code,String currency_name) { 
            this.currency_code = currency_code;
            this.currency_name = currency_name;
        }

        override public String ToString() {
            return currency_code + " " + currency_name;
        }
    }
}
