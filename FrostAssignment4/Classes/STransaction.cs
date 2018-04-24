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
    class STransaction
    {
        public STransaction()
        { }
        public string TransactionID { get; set; }
        public string VendorName { get; set; }
        public string TransactionDate { get; set; } // make a datetime
        public string TransactionAmount { get; set; } // make a double

    }
}