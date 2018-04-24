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
    class Account
    {
        public Account()
        {
        }
       
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }  // can be defined as an enum
        public string AccountID { get; set; }

    }
}