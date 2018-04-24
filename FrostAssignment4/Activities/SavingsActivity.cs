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
    [Activity(Label = "Savings Account Transactions")]
    public class SavingsActivity : Activity
    {
        private List<string> savingstransactions;
        private ListView SavingListView;

    
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Savingspage);
            SavingListView = FindViewById<ListView>(Resource.Id.lstSaving);
           

            savingstransactions = new List<string>();
            savingstransactions.Add("Deposit --- 4/20/18");
            savingstransactions.Add("Deposit --- 4/19/18");
            savingstransactions.Add("Deposit --- 4/18/18");
            savingstransactions.Add("Withdrawl --- 4/17/18");
            savingstransactions.Add("Deposit --- 4/16/18");
            savingstransactions.Add("Withdrawl --- 4/15/18");
            savingstransactions.Add("Deposit --- 4/14/18");
            savingstransactions.Add("Deposit --- 4/13/18");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, savingstransactions);
            SavingListView.Adapter = adapter;

            
            
        }

    }
}