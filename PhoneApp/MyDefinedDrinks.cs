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
                IngredientsWeight = "11",
                DrinkDescription = "opis"
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "drink2",
                DrinkIngredients = "woda",
                IngredientsWeight = "10",
                DrinkDescription = "opis"
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "drink3",
                DrinkIngredients = "ogórek$wóda",
                IngredientsWeight = "1$15",
                DrinkDescription = "Wlać najpierw wódkę do szklanki, tylko dużo dużo dużo, produkuję dużo opisu, a jak dużo wódki już w szklaneczce będzie to wtedy pokroić drobniutko ogóreczka i wrzucić do szklaneczki. Pić bez tzw. \"popity\". Zapraszamy po inne przepisy ze stajni Szalonej Kasi, która obecnie ma fazę na PIKO <3"
            });
           
    
        }
    }
}
