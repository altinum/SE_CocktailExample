using System;
using System.Collections.Generic;
using System.Text;

namespace Se9
{
    public class RecepieEntry
    {
        public int RecepieSk { get; set; }

        public string MaterialName { get; set; } = string.Empty;

        public decimal Quantity { get; set; }

        public string UnitName { get; set; } = string.Empty;
    }
}
