using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.Models
{
    public class Products
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Inventory { get; set; }
        public string Facility { get; set; }
        public string Department { get; set; }
        public string SubDepartment{ get; set; } 
        public string ItemCategory { get; set; }
        public string ItemSubCategory { get; set; }
        public string ItemType { get; set; }
        public string UM { get; set; }
        public string RequiredNote { get; set; }
        public string Discontinued { get; set; }
        public string Cart { get; set; }
        public string GreenFee { get; set; }
        public string GiftCard { get; set; }
        public string Vendor { get; set; }
        public string AwardsPercent { get; set; }
        public string Markup { get; set; }
        public string MarginPercent { get; set; }
        public string MaxDiscPercent { get; set; }
        public string MinPrice { get; set; }
        public string Minimum { get; set; }
        public string Maximum { get; set; }
        public string ReorderQty { get; set; }
        public string InventoryCost { get; set; }
        public string MSRP { get; set; }
        public string ItemCost { get; set; }
        public string ARMinimum { get; set; }
        public string UPC { get; set; }
        public string Printers { get; set; }
        public string RCEligible { get; set; }
        public string RCRedeem { get; set; }
        public string Customer { get; set; }
        public string Range { get; set; }
        public string FiftenPercent { get; set; }
    }
}