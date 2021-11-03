using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FruitPedia.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FruitPedia
{
    [Activity(Label = "New User")]
    public class RegisterUserActivity : AppCompatActivity
    {
        Button b1;
        EditText et1, et2, et3,et4;
        DataLayer layer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_register_user);

            layer = new DataLayer();
            et1 = FindViewById<EditText>(Resource.Id.text1);
            et2 = FindViewById<EditText>(Resource.Id.text2);
            et3 = FindViewById<EditText>(Resource.Id.text3);
            et4 = FindViewById<EditText>(Resource.Id.text4);

            b1 = FindViewById<Button>(Resource.Id.b1);
            b1.Click += B1_Click;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            string username = et1.Text.Trim();
            string age = et2.Text.Trim();
            string pass = et3.Text;
            string cpass = et4.Text;
            if (username.Length == 0 || age.Length == 0 || pass.Length == 0 || cpass.Length == 0)
            {
                Toast.MakeText(this, "Please Fill All Boxes", ToastLength.Long).Show();
            }
            else if (pass.Equals(cpass))
            {
                User user = new User();
                user.UserName = username;
                user.Password = pass;
                user.Age = int.Parse(age);
                if (layer.AddNewUser(user))
                {
                    Intent intent = new Intent(this, typeof(UserHomeActivity));
                    StartActivity(intent);
                    Finish();
                }
                else
                {
                    Toast.MakeText(this, "Error: " + layer.ErrorMessage, ToastLength.Long).Show();
                }
            }
            else
            {
                Toast.MakeText(this, "Confirm Password must be match with Password", ToastLength.Long).Show();
            }

        }
    }
}