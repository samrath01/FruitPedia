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
    [Activity(Label = "Fruits")]
    public class UserAllFruitActivity : AppCompatActivity
    {
        Button b1;
        ListView list1;
        DataLayer layer;
        FruitListAdapter adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_view_all_fruit);

            b1 = FindViewById<Button>(Resource.Id.b1);
            list1 = FindViewById<ListView>(Resource.Id.list1);

            layer = new DataLayer();

            b1.Click += B1_Click; ;

            adapter = new FruitListAdapter(this, layer.GetAllFruits());

            string typename = Intent.GetStringExtra("TypeName");
            if (typename != null)
            {
                adapter = new FruitListAdapter(this, layer.GetFruitsByFruitTypeName(typename));
            }

            list1.Adapter = adapter;

        }

        private void B1_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}