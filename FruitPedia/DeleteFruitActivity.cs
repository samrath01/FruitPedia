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
    [Activity(Label = "Delete Fruit Details")]
    public class DeleteFruitActivity : AppCompatActivity
    {
        Button b1, b2;
        Spinner spinner;
        DataLayer layer;
        FruitSpinnerAdapter adapter;
        List<Fruit> fruits;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_delete_fruit);

            layer = new DataLayer();

            spinner = FindViewById<Spinner>(Resource.Id.spinner);
            b1 = FindViewById<Button>(Resource.Id.b1);
            b2 = FindViewById<Button>(Resource.Id.b2);

            fruits = layer.GetAllFruits();
            adapter = new FruitSpinnerAdapter(this, fruits);
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
            if (fruits != null && fruits.Count() > 0)
            {
                Fruit fruit = fruits[spinner.SelectedItemPosition];
                if (layer.DeleteFruit(fruit))
                {
                    message = "Fruit Details is Removed";
                    fruits.RemoveAt(spinner.SelectedItemPosition);
                    adapter.NotifyDataSetChanged();
                }
                else
                {
                    message = "Fruit Details is not Removed";
                }

            }
            else
            {
                message = "There is Fruit Details is not Available For Delete.";
            }
            Toast.MakeText(this, message, ToastLength.Long).Show();
        }
    }
}