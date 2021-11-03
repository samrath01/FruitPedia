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
    [Activity(Label = "Add New Fruit")]
    public class AddFruitActivity : AppCompatActivity
    {
        Button b1, b2;
        EditText et1,et2;
        Spinner spinner;
        DataLayer layer;
        FruitCategoryListAdapter adapter;        
        List<FruitType> fruitTypes;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add_fruit);
            layer = new DataLayer();

            et1 = FindViewById<EditText>(Resource.Id.text1);
            et2 = FindViewById<EditText>(Resource.Id.text2);
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
            string name = et1.Text.Trim();
            string details = et2.Text.Trim();
            if (name.Length == 0 || details.Length == 0 || fruitTypes == null || fruitTypes.Count() == 0)
            {
                Toast.MakeText(this, "Please Fill Full Form", ToastLength.Long).Show();
            }
            else 
            {
                FruitType type = fruitTypes[spinner.SelectedItemPosition];
                Fruit fruit = new Fruit();
                fruit.FruitName = name;
                fruit.FruitTypeName = type.FruitTypeName;
                fruit.Details = details;
                if (layer.AddNewFruit(fruit))
                {
                    Toast.MakeText(this, "Fruit Details are Saved", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "Fruit Details are not Saved", ToastLength.Long).Show();
                }
            }
        }
    }
}