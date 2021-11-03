using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FruitPedia.Common
{
    public class Fruit
    {
        [PrimaryKey, AutoIncrement]
        public int FruitID { get; set; }

        public string FruitName { get; set; }

        public string FruitTypeName { get; set; }

        public string Details { get; set; }
    }
}