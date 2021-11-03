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
    public class FruitCategoryListAdapter : BaseAdapter<FruitType>
    {
        private readonly Activity context;
        private readonly List<FruitType> fruitTypes;

        public FruitCategoryListAdapter(Activity context, List<FruitType> fruitTypes)
        {
            this.fruitTypes = fruitTypes;
            this.context = context;
        }

        public override int Count
        {
            get { return fruitTypes.Count; }

        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override FruitType this[int position]
        {
            get { return fruitTypes[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.list_fruit_category_row, null, false);
            }

            TextView txt1 = row.FindViewById<TextView>(Resource.Id.text1);

            txt1.Text = fruitTypes[position].FruitTypeName + " (" + fruitTypes[position].FruitTypeID + ")";

            return row;
        }
    }
}