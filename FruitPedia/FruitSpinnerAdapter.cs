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
    public class FruitSpinnerAdapter : BaseAdapter<Fruit>
    {
        private readonly Activity context;
        private readonly List<Fruit> fruits;

        public FruitSpinnerAdapter(Activity context, List<Fruit> fruits)
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
            Fruit fruit = fruits[position];
            TextView txt1 = row.FindViewById<TextView>(Resource.Id.text1);
            txt1.Text = fruit.FruitName + "(" + fruit.FruitTypeName + ")";
            return row;
        }
    }
}