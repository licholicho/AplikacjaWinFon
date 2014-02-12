using System.Data.Linq.Mapping;
using System;

namespace PhoneApp
{

    [Table]
    public class Drink
    {

        [Column(IsPrimaryKey = true)]
        public int DrinkID
        {
            get;
            set;
        }

        [Column(CanBeNull = false)]
        public string DrinkName
        {
            get;
            set;
        }

        [Column(CanBeNull = false)]
        public string DrinkIngredients
        {
            get;
            set;
        }

        [Column(CanBeNull = false)]
        public string IngredientsWeight
        {
            get;
            set;
        }

        [Column(CanBeNull = true)]
        public string DrinkDescription
        {
            get;
            set;
        }

    }
}