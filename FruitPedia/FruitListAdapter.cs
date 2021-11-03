using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FruitPedia.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FruitPedia
{
    class FruitListAdapter : BaseAdapter<Fruit>
    {
        private readonly Activity context;
        private readonly List<Fruit> fruits;

        public FruitListAdapter(Activity context, List<Fruit> fruits)
        {
            this.fruits = fruits;
            this.context = context;
        }

        public override int Count
        {
            get { return fruits.Count; }

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Fruit this[int position]
        {
            get { return fruits[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.list_fruit_row, null, false);
            }
            TextView txt1 = row.FindViewById<TextView>(Resource.Id.text1);
            TextView txt2 = row.FindViewById<TextView>(Resource.Id.text2);
            TextView txt3 = row.FindViewById<TextView>(Resource.Id.text3);
            Fruit fruit = fruits[position];
            txt1.Text = fruit.FruitName;
            txt2.Text = "Category: " + fruit.FruitTypeName;
            txt3.Text = "Details: " + fruit.Details;
            return row;
        }
    }
}