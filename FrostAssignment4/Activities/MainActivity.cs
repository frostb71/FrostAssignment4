using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace FrostAssignment4
{
    [Activity(Label = "CloudBank", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtUserName;
        EditText txtPassword;
        Button btnLogin;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtUserName = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            btnLogin.Click += BtnLogin_Click;


        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            string username = txtUserName.Text.ToLower();
            string password = txtPassword.Text;
            if(username == "clouduser" && password == "318")
            {
                var intent = new Intent(this, typeof(AccountActivity));
                StartActivity(intent);
            }
            else
            {
                string textToDisplay = "Invalid Credentials";
                //Toast toast = new Toast(this);
                
                    Toast.MakeText(this, textToDisplay, ToastLength.Long).Show();
            }
        }
    }
}

