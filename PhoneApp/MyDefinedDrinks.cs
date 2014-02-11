using System;
using System.Collections.Generic;

namespace PhoneApp
{
    public class MyDefinedDrinks
    {

        public List<Drink> ListDrinks = new List<Drink>();

        public MyDefinedDrinks()
        {
            int id = 0;

            //September, 1, 2012 
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "drink1",
                DrinkIngredients = "skla",
                DrinkDescription = "opis"
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "drink3",
                DrinkIngredients = "sklaaasf",
                DrinkDescription = "opis"
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "drink3",
                DrinkIngredients = "skla",
                DrinkDescription = "opisas"
            });
           
    
        }
    }
}
