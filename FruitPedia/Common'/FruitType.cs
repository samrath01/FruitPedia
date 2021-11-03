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
    public class FruitType
    {
        [PrimaryKey, AutoIncrement]
        public int FruitTypeID { get; set; }

        [Unique]
        public string FruitTypeName { get; set; }
    }
}