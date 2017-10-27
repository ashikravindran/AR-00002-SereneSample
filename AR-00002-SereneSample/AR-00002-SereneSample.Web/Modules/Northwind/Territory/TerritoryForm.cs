
namespace AR_00002_SereneSample.Northwind.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Northwind.Territory")]
    [BasedOnRow(typeof(Entities.TerritoryRow))]
    public class TerritoryForm
    {
        public String TerritoryID { get; set; }
        public String TerritoryDescription { get; set; }
        [LookupEditor(typeof(Entities.RegionRow))]
        public Int32 RegionID { get; set; }
    }
}