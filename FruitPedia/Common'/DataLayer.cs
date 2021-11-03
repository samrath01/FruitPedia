using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FruitPedia.Common
{
    public class DataLayer
    {
        private SQLiteConnection connection;

        public string ErrorMessage { get; set; }

        public DataLayer()
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            connection = new SQLiteConnection(Path.Combine(path, "fruits.db"));
            CreateAndSeedData();
        }

        public void CreateAndSeedData()
        {
            try
            {
                connection.CreateTable<User>();
                connection.CreateTable<FruitType>();
                connection.CreateTable<Fruit>();
                List<FruitType> fruitTypes = SeedData.GetFruitTypes();
                foreach(FruitType type in fruitTypes)
                {
                    connection.Insert(type);
                }
                List<Fruit> fruits = SeedData.GetFruits();
                foreach (Fruit fruit in fruits)
                {
                    connection.Insert(fruit);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public bool ValidUser(string username, string password)
        {
            List<User> users = connection.Query<User>("Select * from User");
            if(users!= null && users.Count > 0 )
            {
                foreach(User user in users)
                {
                    if (user.UserName.Equals(username) && user.Password.Equals(password))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AddNewUser(User user)
        {
            try
            {
                connection.Insert(user);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool AddNewFruitType(FruitType fruitType)
        {
            try
            {
                connection.Insert(fruitType);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool AddNewFruit(Fruit fruit)
        {
            try
            {
                connection.Insert(fruit);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public List<FruitType> GetAllFruitTypes()
        {
            List<FruitType> fruitTypes = connection.Query<FruitType>("Select * from FruitType");
            return fruitTypes;
        }

        public List<Fruit> GetAllFruits()
        {
            List<Fruit> fruits = connection.Query<Fruit>("Select * from Fruit");
            return fruits;
        }

        public List<Fruit> GetFruitsByFruitTypeName(string typename)
        {
            List<Fruit> fruits = new List<Fruit>();
            List<Fruit> allFruits = GetAllFruits();
            if (allFruits != null && allFruits.Count > 0)
            {
                foreach (Fruit fruit in allFruits)
                {
                    if (fruit.FruitTypeName.Equals(typename))
                    {
                        fruits.Add(fruit);
                    }
                }
            }
            return fruits;
        }

        public bool SearchFruitByTypeName(string typename)
        {
            List<Fruit> fruits = GetAllFruits();
            if(fruits!=null && fruits.Count > 0)
            {
                foreach(Fruit fruit in fruits)
                {
                    if (fruit.FruitTypeName.Equals(typename))
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool DeleteFruitType(FruitType fruitType)
        {
            try
            {
                connection.Delete(fruitType);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }

        public bool DeleteFruit(Fruit fruit)
        {
            try
            {
                connection.Delete(fruit);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return false;
            }
        }
    }
}