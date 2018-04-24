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
    [Activity(Label = "CloudBank")]
    public class AccountActivity : Activity
    {
        Button btnCheckingAccount;
        Button btnSavingsAccount;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Accountpage);

            btnCheckingAccount = FindViewById<Button>(Resource.Id.btnCheckingAccount);
            btnSavingsAccount = FindViewById<Button>(Resource.Id.btnSavingsAccount);

            btnCheckingAccount.Click += BtnCheckingAccount_Click;
            btnSavingsAccount.Click += BtnSavingsAccount_Click;
            
        }


        private void BtnSavingsAccount_Click(object sender, EventArgs e)
        {
            //Code in here
            var intent = new Intent(this, typeof(SavingsActivity));
            StartActivity(intent);
        }

        private void BtnCheckingAccount_Click(object sender, EventArgs e)
        {
            //Code in here
            var intent = new Intent(this, typeof(CheckingActivity));
            StartActivity(intent);
        }
    }
}