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
    [Activity(Label = "Search By Fruit Category")]
    public class SearchByFruitCategoryActivity : AppCompatActivity
    {
        Button b1, b2;
        Spinner spinner;
        DataLayer layer;
        FruitCategoryListAdapter adapter;
        List<FruitType> fruitTypes;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_search_fruit_by_fruit_category);

            layer = new DataLayer();
            spinner = FindViewById<Spinner>(Resource.Id.spinner);
            b1 = FindViewById<Button>(Resource.Id.b1);
            b2 = FindViewById<Button>(Resource.Id.b2);

            fruitTypes = layer.GetAllFruitTypes();
            adapter = new FruitCategoryListAdapter(this, fruitTypes);
            spinner.Adapter = adapter;

            b1.Click += B1_Click;
            b2.Click += B2_Click;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Finish();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            string message = "";
            if (fruitTypes != null && fruitTypes.Count() > 0)
            {
                FruitType type = fruitTypes[spinner.SelectedItemPosition];
                Intent intent = new Intent(this, typeof(UserAllFruitActivity));
                intent.PutExtra("TypeName", type.FruitTypeName);
                StartActivity(intent);
            }
            else
            {
                message = "There is N0 Such Fruit Category Available For Search.";
                Toast.MakeText(this, message, ToastLength.Long).Show();
            }

        }
    }
}