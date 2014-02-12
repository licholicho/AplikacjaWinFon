﻿using System;
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
                IngredientsWeight = "",
                DrinkDescription = "opis"
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "drink2",
                DrinkIngredients = "woda",
                IngredientsWeight = "",
                DrinkDescription = "opis"
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "drink3",
                DrinkIngredients = "ogórek, woda",
                IngredientsWeight = "",
                DrinkDescription = "opisas"
            });
           
    
        }
    }
}
