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
                DrinkName = "Cinderella",
                DrinkIngredients = "orange juice$pineapple juice$lemon juice$sugar syrup$soda water",
                IngredientsWeight = "50$50$25$15$15",
                DrinkDescription = "Shake and strain into an ice-filled highball glass, and add soda. Decorate with a slice of lemon, add a straw, and serve."

            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Apello",
                DrinkIngredients = "orange juice$grapefruit juice$apple juice",
                IngredientsWeight = "40$30$10",
                DrinkDescription = "Stir together in a highball glass. Decorate with a maraschino cherry, and serve."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Evil Princess",
                DrinkIngredients = "grenadine syrup$grape juice$apple juice$vanilla syrup$lemon juice",
                IngredientsWeight = "25$50$25$15$15",
                DrinkDescription = "Pour over ice, stir and decorate with a lime slice."
            });

            ListDrinks.Add(new Drink
        {
            DrinkID = id++,
            DrinkName = "Fruit Cocktail",
            DrinkIngredients = "orange juice$grapefruit juice$passion-fruit juice$mango juice$pineapple juice$lime juice$kiwi syrup",
            IngredientsWeight = "25$25$25$25$25$7$15",
            DrinkDescription = "Shake with a glassful of broken ice and pour unstrained into a wine goblet. Decorate with fruit, add straws, and serve."
        });

            ListDrinks.Add(new Drink
        {
            DrinkID = id++,
            DrinkName = "Fuzzless Navel",
            DrinkIngredients = "peach nectar$orange juice",
            IngredientsWeight = "50$150",
            DrinkDescription = "Pour peach nectar and orange juice into a chilled glass filled with ice cubes. Stir well and decorate with a slice of orange."
        });

            ListDrinks.Add(new Drink
        {
            DrinkID = id++,
            DrinkName = "Kiba",
            DrinkIngredients = "cherry juice$banana juice",
            IngredientsWeight = "100$100",
            DrinkDescription = "Pour all ingredients into a highball glass over ice cubes and serve."
        });

            ListDrinks.Add(new Drink
      {
          DrinkID = id++,
          DrinkName = "Mandate",
          DrinkIngredients = "mandarin juice$lemon soda$raspberry syrup",
          IngredientsWeight = "100$75$15",
          DrinkDescription = "Add to an ice filled wine goblet."
      });
            ListDrinks.Add(new Drink
      {
          DrinkID = id++,
          DrinkName = "Mock Daisy Crusta",
          DrinkIngredients = "lime juice$sugar syrup$raspberry syrup$grenadine syrup$soda water",
          IngredientsWeight = "40$25$15$7$75",
          DrinkDescription = "Rim a wine glass with lime/caster sugar, add a spiral of lime, and fill with crushed ice. Stir lime juice and syrups together, and strain into the glass. Add the soda and sprinkle the grenadine on top."
      });

            ListDrinks.Add(new Drink
  {
      DrinkID = id++,
      DrinkName = "Cat Foot",
      DrinkIngredients = "grenadine syrup$pineapple juice$orange juice$grapefruit juice",
      IngredientsWeight = "10$40$40$40",
      DrinkDescription = "Shake or blend briefly, and strain into a highball glass. Decorate with fresh fruit and a cherry. Add a straw, and serve."
  });

            ListDrinks.Add(new Drink
  {
      DrinkID = id++,
      DrinkName = "Rosemary",
      DrinkIngredients = "strawberry puree$guava juice$pineapple juice$lime juice$strawberry syrup$lemonade",
      IngredientsWeight = "75$25$25$7$15$50",
      DrinkDescription = "Shake all ingredients (except lemonade) and strain into a highball glass three-quarters filled with crushed ice. Add lemonade, decorate with a slice of lime and a strawberry, add straws and serve."
  });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Pomola",
                DrinkIngredients = "lime juice$chilled cola$grenadine syrup",
                IngredientsWeight = "25$125$7",
                DrinkDescription = "Pour into an ice-filled highball glass. Decorate with a slice of lime."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Queen Charlie",
                DrinkIngredients = "grenadine syrup$soda water$lemonade",
                IngredientsWeight = "15$75$75",
                DrinkDescription = "Pour into an ice-filled highball glass. Decorate with fruit, and serve with a straw."
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Kiddie Cocktail",
                DrinkIngredients = "lemon soda$grenadine syrup",
                IngredientsWeight = "200$30",
                DrinkDescription = "Build in a highball glass. Add 7-up or sprite over ice and sprinkle grenadine syrup over it. Decorate with a lemon slice and a cherry."
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Babylove",
                DrinkIngredients = "coconut milk$cream$pineapple juice$banana syrup",
                IngredientsWeight = "40$20$50$20",
                DrinkDescription = "Shake well over crushed ice in a shaker. Strain into a collins glass and fill with crushed ice."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Choco choco",
                DrinkIngredients = "milk$cream$coconut cream$chocolate syrup",
                IngredientsWeight = "90$20$20$50",
                DrinkDescription = "Shake liquids well over ice cubes in a shaker, and strain into a large highball glass over crushed ice."
            });

        }
    }
}
