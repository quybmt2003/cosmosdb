using System;
using System.Collections;
using System.Collections.Generic;

namespace CosmosDB.Model
{
    public class CuttingTool
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<CuttingToolItem> CuttingToolItems { get; set; }
    }
}
