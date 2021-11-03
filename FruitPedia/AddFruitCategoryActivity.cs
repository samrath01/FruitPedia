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
    [Activity(Label = "Add New Fruit Category")]
    public class AddFruitCategoryActivity : AppCompatActivity
    {
        EditText et1;
        Button b1, b2;
        DataLayer layer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add_fruit_category);
            layer = new DataLayer();
            et1 = FindViewById<EditText>(Resource.Id.text1);

            b1 = FindViewById<Button>(Resource.Id.b1);
            b2 = FindViewById<Button>(Resource.Id.b2);
            b1.Click += B1_Click;
            b2.Click += B2_Click;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            string typename = et1.Text.Trim();
            string message = "";
            if (typename.Length == 0 )
            {
                message = "Please Enter Some Value in Boxes";
            }
            else
            {
                FruitType fruitType = new FruitType();
                fruitType.FruitTypeName = typename;
                if (layer.AddNewFruitType(fruitType))
                {
                    message = "Fruit Category Details are Saved!!!";
                    et1.Text = "";
                }
                else
                {
                    message = layer.ErrorMessage;
                }
            }
            Toast.MakeText(this, message, ToastLength.Long).Show();
        }
    }
}