using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexGenAPi
{
    public partial class BundlesDTO
    {
        public Int64 MaxBundleSize { get; set; }
        public Int64 MaxCost { get; set; }
        public Int64 MinBundleSize { get; set; }
        public Int64 MinCost { get; set; }
        public List<Response> Response { get; set; }
        public long StatusCode { get; set; }
    }

    public partial class Response
    {
        public string Bundle_Name { get; set; }
        public string Bundle_Type { get; set; }
        public string Bundle_Nact_Code { get; set; }
        public string Bundle_Expiry_Date { get; set; }
        public string Bundle_Subscription_Type { get; set; }
        //public List <BundleDaCodeElement>BundleDaCodes { get; set; }
        public string Bundle_Id { get; set; }
        public string Bundle_Popular { get; set; }
        public string Bundle_Offer { get; set; }
        public string Bundle_Data_Offer { get; set; }
        public string Bundle_Combo_Offer { get; set; }
        public string ProductId { get; set; }
        public string ProductCategoryId { get; set; }
        public BundleCost BundleCost { get; set; }
        public List<BundleRule> Bundle_Rule { get; set; }
        public BundleValue BundleValue { get; set; }
        public BundleValidity BundleValidity { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public PaymentOptions PaymentOptions { get; set; }
        //public DateTimeOffset Created { get; set; }
        //public DateTimeOffset Modified { get; set; }
        public string Bundle_Recurring { get; set; }
        public string Bundle_Auto_Renewable { get; set; }
    }


    public partial class BundleCost
    {
        public string Bundle_Cost_Label_Label { get; set; }
        public double Value { get; set; }
        public string Unit { get; set; }
        public double DisplayValue { get; set; }
        public string DisplayName { get; set; }
    }

    public partial class BundleRule
    {
        public string Rule_Id { get; set; }
        public string Rule_Name { get; set; }
        public string Rule_Description { get; set; }
        public string Rule_Icon { get; set; }
    }

    public partial class BundleValidity
    {
        public string BundleValidityLabel_Label { get; set; }
        public string Value { get; set; }
        public string DisplayValue_Unit { get; set; }
        public string DisplayValue { get; set; }
        public string DisplayName { get; set; }
    }

    public partial class BundleValue
    {
        public int BundleType_Label { get; set; }
        public string Value { get; set; }
        public int Unit { get; set; }
        public string DisplayValue { get; set; }
        public string DisplayName { get; set; }
        public string Bonus { get; set; }
        public PackageDeal[] PackageDeal { get; set; }
    }

    public partial class PackageDeal
    {
        public string BundleTypeLabel { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
        public string DisplayValue { get; set; }
        public string Currency { get; set; }
        public string DisplayName { get; set; }
        public BundleRate OutOfBundleRate { get; set; }
        public BundleRate BundleRate { get; set; }
        public string Bonus { get; set; }
    }

    public partial class BundleRate
    {
        public string ProductType { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public string Currency { get; set; }
        public string DisplayValue { get; set; }
        public string DisplayName { get; set; }
    }

    public partial class PaymentOptions
    {
        public Airtime Momo { get; set; }
        public Airtime Airtime { get; set; }
        public Airtime Card { get; set; }
        public Airtime Loan { get; set; }
    }

    public partial class Airtime
    {
        public string Method { get; set; }
        public bool Available { get; set; }
        public string ErrorMessage { get; set; }
    }

    public partial class ProductCategory
    {
        public string ProductCategoryName { get; set; }
        public string ProductCategoryId { get; set; }
        public string ProductCategoryDescription { get; set; }
        public string ProductId { get; set; }
        public string Product { get; set; }
        public FilterTab[] FilterTabs { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
    }

    public partial class FilterTab
    {
        public string FilterTabName { get; set; }
        public string FilterCriteria { get; set; }
    }



    
}
