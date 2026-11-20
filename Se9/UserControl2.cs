using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Se9
{
    public partial class UserControl2 : UserControl
    {
        CocktailModels.SeCocktailsContext context = new CocktailModels.SeCocktailsContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            cocktailBindingSource.DataSource = context.Cocktails.ToList();
            materialBindingSource.DataSource = context.Materials.ToList();
        }

        private void cocktailBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cocktailBindingSource.Current == null) return;

            CocktailModels.Cocktail sc = cocktailBindingSource.Current as CocktailModels.Cocktail;

            var rrrrrr = from x in context.Recipes
                         where x.CocktailFk == sc.CocktailSk
                         select new RecepieEntry
                         {
                             RecepieSk = x.RecipeSk,
                             MaterialName = x.MaterialFkNavigation.Name,
                             Quantity = x.Quantity,
                             UnitName = x.MaterialFkNavigation.UnitFkNavigation.Name
                         };

            recepieEntryBindingSource.DataSource = rrrrrr.ToList();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (cocktailBindingSource.Current == null) return;
            if (materialBindingSource.Current == null) return;

            CocktailModels.Cocktail selectedCocktail = cocktailBindingSource.Current as CocktailModels.Cocktail;
            CocktailModels.Material selectedMaterial = materialBindingSource.Current as CocktailModels.Material;

            CocktailModels.Recipe newRecipe = new CocktailModels.Recipe
            {
                CocktailFk = selectedCocktail.CocktailSk,
                MaterialFk = selectedMaterial.MaterialId,
                Quantity = numericUpDown1.Value
            };

            context.Recipes.Add(newRecipe);
            context.SaveChanges();
            //ToDo: error handling

            // Refresh the recipe list
            cocktailBindingSource_CurrentChanged(sender, e);

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(recepieEntryBindingSource.Current == null) return;

            RecepieEntry selectedRecipe = recepieEntryBindingSource.Current as RecepieEntry;

            var recepiesToBeRemoved = from x in context.Recipes
                                      where x.RecipeSk == selectedRecipe.RecepieSk
                                      select x;

            context.Recipes.RemoveRange(recepiesToBeRemoved);

            context.SaveChanges();

            // Refresh the recipe list
            cocktailBindingSource_CurrentChanged(sender, e);
        }
    }
}
