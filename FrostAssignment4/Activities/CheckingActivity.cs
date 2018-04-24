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
using FrostAssignment4.Activities;

namespace FrostAssignment4
{

    //one transaction activity, not two 
    [Activity(Label = "Checking Account Transactions")]
    public class CheckingActivity : Activity
    {
        public List<string> CheckingTransactions;
        private ListView CheckingListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Checkingpage);

            CheckingListView = FindViewById<ListView>(Resource.Id.lstChecking);
           
            CheckingTransactions = new List<string>();
            CheckingTransactions.Add("Buger King 4/24/18");
            CheckingTransactions.Add("Transaction");
            CheckingTransactions.Add("Transaction");
            CheckingTransactions.Add("Transaction");
            CheckingTransactions.Add("Transaction");
            CheckingTransactions.Add("Transaction");
            CheckingTransactions.Add("Transaction");
            CheckingTransactions.Add("Transaction");

            // create a foreach loop 

            Random randomNumber = new Random();
            double transactionCost = randomNumber.Next(25, 99);

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, CheckingTransactions);
            CheckingListView.Adapter = adapter;





























            // Create your application here
            //SetContentView(Resource.Layout.Checkingpage);
            //CheckingListView = FindViewById<ListView>(Resource.Id.lstChecking);

            //CheckingTransactions.Add(new CTransaction() { ID = "0001", Date = "2/22/18", Vendor = "Walmart", Amount = "$100.00" });

            //checkingtransactions = new List<CTransaction>();
            //checkingtransactions.Add("Target --- 4/20/18");
            //checkingtransactions.Add("Walmart --- 4/19/18");
            //checkingtransactions.Add("Best Buy --- 4/18/18");
            //checkingtransactions.Add("McDonalds --- 4/17/18");
            //checkingtransactions.Add("Panera Bread --- 4/16/18");
            //checkingtransactions.Add("Lowe's --- 4/15/18");
            //checkingtransactions.Add("Festival Foods --- 4/14/18");
            //checkingtransactions.Add("Best Buy --- 4/13/18");

            //MyListViewAdapter adapter = new MyListViewAdapter(this, CheckingTransactions);

            ////ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, CheckingTransactions);
            //CheckingListView.Adapter = adapter;
        }
    }
}