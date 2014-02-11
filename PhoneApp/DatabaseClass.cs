using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneApp
{
    public class DatabaseClass
    {

        MyDataContext DrinksDB = new MyDataContext(@"isostore:/DrinksDB.sdf");

        private static int LastEventIndex;

        public DatabaseClass()
        {
            if (CreateDatabase())
            {
                MyDefinedDrinks definedevents = new MyDefinedDrinks();
                FillDatabase(definedevents.ListDrinks);
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
                //Events Database already exists!!!
                return false;
            }
        }

        public bool FillDatabase(List<Drink> ListDrinks)
        {
            LastEventIndex = 0;
            try
            {
                foreach (Drink drink in ListDrinks)
                {
                    DrinksDB.Drinks.InsertOnSubmit(drink);
                   
                    DrinksDB.SubmitChanges();
                    LastEventIndex++;
                }
                return true;
            }
            catch (Exception exc) { return false; }
        }

        public IList<Drink> GetDrinksList()
        {
            try
            {
                // Fetching data from local database
                IList<Drink> DrinksList = null;
                {
                    IQueryable<Drink> EmpQuery = from Evnt in DrinksDB.Drinks select Evnt;
                    DrinksList = EmpQuery.ToList();
                }
                return DrinksList;
            }
            catch (Exception exc) { return null; }
        }
/*
        public IList<Ingredient> GetIngredientsList()
        {
            try
            {
                // Fetching data from local database
                IList<Ingredient> IngredientsList = null;
                {
                    IQueryable<Ingredient> EmpQuery = from Evnt in DrinksDB.Ingredients select Evnt;
                    IngredientsList = EmpQuery.ToList();
                }
                return IngredientsList;
            }
            catch (Exception exc) { return null; }
        }
        */
        public bool AddDrink(Drink drink)
        {

            drink.DrinkID = LastEventIndex + 1; //give it the biggest ID

            //evnt.EventID = EventsDB.Events.Last().EventID + 1; 
            try
            {
                DrinksDB.Drinks.InsertOnSubmit(drink);
                DrinksDB.SubmitChanges();
                LastEventIndex++;
                return true;
            }
            catch (Exception exc) { return false; }
        }

       /* public bool AddIngredient(Ingredient i)
        {

            i.IngredientID = LastEventIndex + 1; //give it the biggest ID

            //evnt.EventID = EventsDB.Events.Last().EventID + 1; 
            try
            {
                DrinksDB.Drinks.InsertOnSubmit(drink);
                DrinksDB.SubmitChanges();
                LastEventIndex++;
                return true;
            }
            catch (Exception exc) { return false; }
        }
        */
        public bool EditDrink(Drink evnt)
        {
            try
            {
                // Query for a specific Event
                IQueryable<Drink> DrinkQuery = from ev in DrinksDB.Drinks where ev.DrinkID == evnt.DrinkID select ev;
                //Drink evntEdit = EvntQuery.FirstOrDefault();
                DrinkQuery.First().DrinkName = evnt.DrinkName;
                DrinkQuery.First().DrinkIngredients = evnt.DrinkIngredients;
                DrinkQuery.First().DrinkID = evnt.DrinkID;
                DrinkQuery.First().DrinkDescription = evnt.DrinkDescription;

                DrinksDB.SubmitChanges();

                return true;
            }
            catch (Exception exc) { return false; }
        }

        public bool DeleteDrink(int drinkId)
        {
            try
            {
                IQueryable<Drink> DrinkQuery = from Evnt in DrinksDB.Drinks where Evnt.DrinkID == drinkId select Evnt;
                Drink DrinkRemove = DrinkQuery.FirstOrDefault();
                DrinksDB.Drinks.DeleteOnSubmit(DrinkRemove);
                DrinksDB.SubmitChanges();
                return true;
            }
            catch (Exception exc) { return false; }
        }
    }
}
