using System.Data.Linq.Mapping;
using System;

namespace PhoneApp
{
    [Table]
    public class Ingredient
    {
  
            [Column(IsPrimaryKey = true)]
            public int IngredientID
            {
                get;
                set;
            }

            [Column(CanBeNull = false)]
            public string IngredientName
            {
                get;
                set;
            }

            [Column(CanBeNull = false)]
            public int IngredientAmount
            {
                get;
                set;
            }

  

        
    }
}
