using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FrostAssignment4
{
    public class CTransaction
    {  
       
        public CTransaction()
        { }
        public string TransactionID { get; set; }
        public string VendorName { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionAmount { get; set; }
   
    }
}