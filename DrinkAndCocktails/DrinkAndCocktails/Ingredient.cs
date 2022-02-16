﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndCocktails
{
    public class Ingredient
    {
        public string Name { get; set; }
        public IngredientType AmmountType { get; set; }
        public int Ammount { get; set; }
        public Ingredient(string name, IngredientType type)
        {
            Name = name;
            AmmountType = type;
        }
    }
}
