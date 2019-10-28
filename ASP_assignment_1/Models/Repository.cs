﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asgn2.Models
{
    public static class Repository
    {


        private static IQueryable<Recipes> allRecipes = new List<Recipes>
        {

              new Recipes {RecipeID =1, Name = "Salmon",Ingredients="Ssd", Description="Blabla"},
              new Recipes {RecipeID =2, Name = "Chicken",Ingredients="Ssd", Description="Ulala"},
              new Recipes {RecipeID =3, Name = "Duck",Ingredients="Ssd", Description="Mak"}
          }.AsQueryable<Recipes>();

        public static IQueryable<Recipes> Recipes
        {
            get
                {
                return allRecipes;
            }
        }


        public static void AddResponse(Recipes guestRecipe)
        {
            allRecipes.ToList().Add(guestRecipe);
        
        }






    }
}
