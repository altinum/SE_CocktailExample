using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Se9
{
    public partial class UserControl1 : UserControl
    {
        CocktailModels.SeCocktailsContext context = new CocktailModels.SeCocktailsContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            cocktailBindingSource.DataSource = context.Cocktails.ToList();
            typeBindingSource.DataSource = context.Types.ToList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
