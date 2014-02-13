using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneApp
{
    public class DatabaseClass
    {
        MyDataContext DrinksDB = new MyDataContext(@"isostore:/DrinksDB.sdf");

        private static int LastDrinkIndex;

        public DatabaseClass()
        {
            if (CreateDatabase())
            {
                MyDefinedDrinks definedDrinks = new MyDefinedDrinks();
                FillDatabase(definedDrinks.ListDrinks);
            }
        }

        public Boolean CreateDatabase()
        {
            if (DrinksDB.DatabaseExists() == false)
            {
                try
                {
                    DrinksDB.CreateDatabase();
                    return true;
                }
                catch (Exception exc) { return false; }
            }
            else
            {
                return false;
            }
        }

        public bool FillDatabase(List<Drink> ListDrinks)
        {
            LastDrinkIndex = 0;
            try
            {
                foreach (Drink drink in ListDrinks)
                {
                    DrinksDB.Drinks.InsertOnSubmit(drink);
                   
                    DrinksDB.SubmitChanges();
                    LastDrinkIndex++;
                }
                return true;
            }
            catch (Exception exc) { return false; }
        }

        public IList<Drink> GetDrinksList()
        {
            try
            {
                IList<Drink> DrinksList = null;
                {
                    IQueryable<Drink> EmpQuery = (from Drin in DrinksDB.Drinks select Drin).OrderBy(e => e.DrinkName);
                    DrinksList = EmpQuery.ToList();
                }
                return DrinksList;
            }
            catch (Exception exc) { return null; }
        }

        public bool AddDrink(Drink drink)
        {
            drink.DrinkID = LastDrinkIndex + 1; 
            try
            {
                DrinksDB.Drinks.InsertOnSubmit(drink);
                DrinksDB.SubmitChanges();
                LastDrinkIndex++;
                return true;
            }
            catch (Exception exc) { return false; }
        }

        public bool EditDrink(Drink drn)
        {
            try
            {
                IQueryable<Drink> DrinkQuery = from dr in DrinksDB.Drinks where dr.DrinkID == drn.DrinkID select dr;
                DrinkQuery.First().DrinkName = drn.DrinkName;
                DrinkQuery.First().DrinkIngredients = drn.DrinkIngredients;
                DrinkQuery.First().DrinkID = drn.DrinkID;
                DrinkQuery.First().DrinkDescription = drn.DrinkDescription;

                DrinksDB.SubmitChanges();

                return true;
            }
            catch (Exception exc) { return false; }
        }

        public Drink GetDrink(string name)
        {
            try
            {
                // Query for a specific Event
                IQueryable<Drink> DrinkQuery = from dr in DrinksDB.Drinks where dr.DrinkName == name select dr;
                Drink Get = DrinkQuery.FirstOrDefault();
                return Get;
            }
            catch (Exception exc) { return null; }
        }

        public Drink GetDrinkByID(int id)
        {
            try
            {
                // Query for a specific Event
                IQueryable<Drink> DrinkQuery = from dr in DrinksDB.Drinks where dr.DrinkID == id select dr;
                Drink Get = DrinkQuery.FirstOrDefault();
                return Get;
            }
            catch (Exception exc) { return null; }
        }


        public bool DeleteDrink(int drinkId)
        {
            try
            {
                IQueryable<Drink> DrinkQuery = from Drin in DrinksDB.Drinks where Drin.DrinkID == drinkId select Drin;
                Drink DrinkRemove = DrinkQuery.FirstOrDefault();
                DrinksDB.Drinks.DeleteOnSubmit(DrinkRemove);
                DrinksDB.SubmitChanges();
                return true;
            }
            catch (Exception exc) { return false; }
        }
    }
}
