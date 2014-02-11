﻿using System.Data.Linq;

namespace PhoneApp
{
    public class MyDataContext : DataContext
    {
        public MyDataContext(string connectionString)
            : base(connectionString)
        {
        }
        public Table<Drink> Drinks
        {
            get
            {
                return this.GetTable<Drink>();
            }
        }
/*
        public Table<Ingredient> Ingredients
        {
            get
            {
                return this.GetTable<Ingredient>();
            }
        }*/
    }
}
