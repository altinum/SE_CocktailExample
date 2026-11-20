using System;
using System.Collections.Generic;

namespace Se9.CocktailModels;

public partial class Material
{
    public short MaterialId { get; set; }

    public string Name { get; set; } = null!;

    public int? TypeFk { get; set; }

    public byte? UnitFk { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual MaterialType? TypeFkNavigation { get; set; }

    public virtual Unit? UnitFkNavigation { get; set; }
}
