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

namespace FrostAssignment4.Activities
{ }
    //class MyListViewAdapter : BaseAdapter<CTransaction>
    //{ 
    //    public List<CTransaction> CheckingTransactions;
    //    public Context mcontext;

    //    public MyListViewAdapter(Context context, List<CTransaction> transactions)
    //    {
    //        CheckingTransactions = transactions;
    //        mcontext = context;
    //    }
    //    public override int Count
    //    {
    //        get { return CheckingTransactions.Count; }
    //    }

    //    public override long GetItemId(int position)
    //    {
    //        return position;
    //    }

    //    public override CTransaction this[int position]
    //    {
    //        get { return CheckingTransactions[position]; }
    //    }

    //    public override View GetView(int position, View convertView, ViewGroup parent)
    //    {
    //        View row = convertView;
    //        if(row == null)
    //        {
    //            row = LayoutInflater.From(mcontext).Inflate(Resource.Layout.Checkingpage, null, false);
    //        }

    //        TextView txtID = row.FindViewById<TextView>(Resource.Id.txtTransactionID);
    //        txtID.Text = CheckingTransactions[position].ID;

    //        TextView txtVendor = row.FindViewById<TextView>(Resource.Id.txtvendor);
    //        txtVendor.Text = CheckingTransactions[position].Vendor;

    //        TextView txtDate = row.FindViewById<TextView>(Resource.Id.txtDate);
    //        txtDate.Text = CheckingTransactions[position].Date;

    //        TextView txtAmount = row.FindViewById<TextView>(Resource.Id.txtAmount);
    //        txtAmount.Text = CheckingTransactions[position].Amount;

    //        return row;
//        }
//    }
//}