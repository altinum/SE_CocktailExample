using System;
using System.Collections.Generic;

namespace Se9.CocktailModels;

public partial class Type
{
    public int TypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
}
