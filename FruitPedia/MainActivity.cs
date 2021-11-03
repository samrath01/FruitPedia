using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using FruitPedia.Common;
using Android.Content;

namespace FruitPedia
{
    [Activity(Label = "Login Screen", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        Button b1,b2;
        EditText et1, et2;
        DataLayer layer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            layer = new DataLayer();
            et1 = FindViewById<EditText>(Resource.Id.text1);
            et2 = FindViewById<EditText>(Resource.Id.text2);

            b1 = FindViewById<Button>(Resource.Id.b1);
            b2 = FindViewById<Button>(Resource.Id.b2);
            b1.Click += B1_Click;
            b2.Click += B2_Click;
        }
        private void B1_Click(object sender, System.EventArgs e)
        {
            string username = et1.Text.Trim();
            string password = et2.Text;
            if (username.Length == 0 || password.Length == 0)
            {
                Toast.MakeText(this, "Please Fill All Boxes", ToastLength.Long).Show();
            }
            else
            {
                if (username.Equals("fruit") && password.Equals("fruit@1234"))
                {
                    Intent intent = new Intent(this, typeof(AdminHomeActivity));
                    StartActivity(intent);
                    Finish();
                }
                else if (layer.ValidUser(username, password))
                {
                    Intent intent = new Intent(this, typeof(UserHomeActivity));
                    StartActivity(intent);
                    Finish();
                }
                else
                {
                    Toast.MakeText(this, "Invalid User Name and Password", ToastLength.Long).Show();
                }
            }

        }
        private void B2_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(RegisterUserActivity));
            Finish();
        }
    }
}