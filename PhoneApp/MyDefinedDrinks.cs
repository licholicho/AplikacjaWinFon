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

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Sweet Tropico",
                DrinkIngredients = "orange juice$pineapple juice$lemon juice$sugar syrup$soda water",
                IngredientsWeight = "50$50$25$15$15",
                DrinkDescription = "Shake and strain into an ice-filled highball glass, and add soda. Decorate with a slice of lemon, add a straw, and serve."

            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Early Morning",
                DrinkIngredients = "orange juice$grapefruit juice$apple juice",
                IngredientsWeight = "40$30$10",
                DrinkDescription = "Stir together in a highball glass. Decorate with a maraschino cherry, and serve."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Demon Prince",
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
            DrinkName = "Crazy Orange",
            DrinkIngredients = "peach nectar$orange juice",
            IngredientsWeight = "50$150",
            DrinkDescription = "Pour peach nectar and orange juice into a chilled glass filled with ice cubes. Stir well and decorate with a slice of orange."
        });

            ListDrinks.Add(new Drink
        {
            DrinkID = id++,
            DrinkName = "Twighlight",
            DrinkIngredients = "cherry juice$banana juice",
            IngredientsWeight = "100$100",
            DrinkDescription = "Pour all ingredients into a highball glass over ice cubes and serve."
        });

            ListDrinks.Add(new Drink
      {
          DrinkID = id++,
          DrinkName = "Evil Mandarin",
          DrinkIngredients = "mandarin juice$lemon soda$raspberry syrup",
          IngredientsWeight = "100$75$15",
          DrinkDescription = "Add to an ice filled wine goblet."
      });
            ListDrinks.Add(new Drink
      {
          DrinkID = id++,
          DrinkName = "Bloody Night",
          DrinkIngredients = "lime juice$sugar syrup$raspberry syrup$grenadine syrup$soda water",
          IngredientsWeight = "40$25$15$7$75",
          DrinkDescription = "Rim a wine glass with lime/caster sugar, add a spiral of lime, and fill with crushed ice. Stir lime juice and syrups together, and strain into the glass. Add the soda and sprinkle the grenadine on top."
      });

            ListDrinks.Add(new Drink
  {
      DrinkID = id++,
      DrinkName = "Nyan~~",
      DrinkIngredients = "grenadine syrup$pineapple juice$orange juice$grapefruit juice",
      IngredientsWeight = "10$40$40$40",
      DrinkDescription = "Shake or blend briefly, and strain into a highball glass. Decorate with fresh fruit and a cherry. Add a straw, and serve."
  });

            ListDrinks.Add(new Drink
  {
      DrinkID = id++,
      DrinkName = "Hephaestus",
      DrinkIngredients = "strawberry puree$guava juice$pineapple juice$lime juice$strawberry syrup$lemonade",
      IngredientsWeight = "75$25$25$7$15$50",
      DrinkDescription = "Shake all ingredients (except lemonade) and strain into a highball glass three-quarters filled with crushed ice. Add lemonade, decorate with a slice of lime and a strawberry, add straws and serve."
  });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Persephone",
                DrinkIngredients = "lime juice$chilled cola$grenadine syrup",
                IngredientsWeight = "25$125$7",
                DrinkDescription = "Pour into an ice-filled highball glass. Decorate with a slice of lime."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Wings Of Wisdom",
                DrinkIngredients = "grenadine syrup$soda water$lemonade",
                IngredientsWeight = "15$75$75",
                DrinkDescription = "Pour into an ice-filled highball glass. Decorate with fruit, and serve with a straw."
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Wolfdire",
                DrinkIngredients = "lemon soda$grenadine syrup",
                IngredientsWeight = "200$30",
                DrinkDescription = "Build in a highball glass. Add 7-up or sprite over ice and sprinkle grenadine syrup over it. Decorate with a lemon slice and a cherry."
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Little Baby",
                DrinkIngredients = "coconut milk$cream$pineapple juice$banana syrup",
                IngredientsWeight = "40$20$50$20",
                DrinkDescription = "Shake well over crushed ice in a shaker. Strain into a collins glass and fill with crushed ice."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Chico Choc",
                DrinkIngredients = "milk$cream$coconut cream$chocolate syrup",
                IngredientsWeight = "90$20$20$50",
                DrinkDescription = "Shake liquids well over ice cubes in a shaker, and strain into a large highball glass over crushed ice."
            });
            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Virgin Colada",
                DrinkIngredients = "pineapple juice$coconut cream$whipping cream$lime juice",
                IngredientsWeight = "75$50$10$20",
                DrinkDescription = "Shake and strain into a wine goblet filled with crushed ice. Decorate with a slice of pineapple and a cherry, add a straw, and serve."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Green Banana",
                DrinkIngredients = "orange juice$Blue Curacao syrup$banana syrup",
                IngredientsWeight = "200$20$30",
                DrinkDescription = "Pour over ice, stir and decorate with a lime slice."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Passionate",
                DrinkIngredients = "orange juice$pineapple juice$passion fruit syrup$Blue Curacao syrup",
                IngredientsWeight = "100$100$15$5",
                DrinkDescription = "Pour into a shaker and shake with ice cubes. Pour into a glass over ice. Decorate with mint leaves."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Paradise",
                DrinkIngredients = "coconut milk$strawberry syrup$orange juice$cream",
                IngredientsWeight = "30$30$80$60",
                DrinkDescription = "Pour ingredients into a shaker, mix vigorously with ice cubes and pour into a fancy glass."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Cruel Intentions",
                DrinkIngredients = "orange juice$lemon juice$vanilla syrup$Blue Curacao",
                IngredientsWeight = "200$20$25$5",
                DrinkDescription = "Shake juices with vanilla syrup. Pour into a tall glass, then pour a few drops of Blue Curacao."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Keep Sober",
                DrinkIngredients = "cola$tonic$lemon juice",
                IngredientsWeight = "110$110$20",
                DrinkDescription = "Mix all the ingredients in a glass."
            });

            ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Surfer",
                DrinkIngredients = "apple juice$orange juice$grenadine syrup",
                IngredientsWeight = "100$100$15",
                DrinkDescription = "Pour juices over ice. Add a teaspoon of grenadine syrup, do not mix."
            });

                ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Beautiful Sunset",
                DrinkIngredients = "cream$banana juice$grenadine syrup",
                IngredientsWeight = "100$100$15",
                DrinkDescription = "Mix ingredients in a shaker with ice cubes and pour into a glass."
            });

        ListDrinks.Add(new Drink
            {
                DrinkID = id++,
                DrinkName = "Cherry Lady",
                DrinkIngredients = "cherry juice$passion fruit juice$tonic",
                IngredientsWeight = "50$50$50",
                DrinkDescription = "Pour over ice and stir."
            });


        ListDrinks.Add(new Drink
        {
            DrinkID = id++,
            DrinkName = "CocoPalm",
            DrinkIngredients = "pineapple juice$coconut milk",
            IngredientsWeight = "150$70",
            DrinkDescription = "Mix all ingredients, pour over ice and serve in a tall glass."
        });

        ListDrinks.Add(new Drink
        {
            DrinkID = id++,
            DrinkName = "ExoTico",
            DrinkIngredients = "orange juice$pineapple juice$lime juice$soda water",
            IngredientsWeight = "50$50$25$10$25",
            DrinkDescription = "Pour all ingredients into a shaker. Mix with ice and pour into a tall glass. Fill up with soda water and decorate with a lemon slice."
        });

        ListDrinks.Add(new Drink
        {
            DrinkID = id++,
            DrinkName = "Duo Coloro",
            DrinkIngredients = "milk$banana juice$grenadine syrup$Blue Curacao syrup",
            IngredientsWeight = "30$70$15$15",
            DrinkDescription = "Blend milk with banana juice. Devide the resulting mass into two equal parts. Add Blue Curacao syrup to first part blue and grenadine syrup to the second red. Mix each mass separately. Pour both into the glass to form two equal layers. "
        });



        }
    }
}
