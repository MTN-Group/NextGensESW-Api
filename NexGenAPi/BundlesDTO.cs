using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexGenAPi
{
    public partial class BundlesDTO
    {
        public Int64 max_bundle_size { get; set; }
        public Int64 max_cost { get; set; }
        public Int64 min_bundle_size { get; set; }
        public Int64 min_cost { get; set; }
        public List<Response> Response { get; set; }
        public long StatusCode { get; set; }
    }

    public partial class Response
    {
        public string bundle_name { get; set; }
        public string bundle_type { get; set; }
        public string bundle_nact_code { get; set; }
        public string bundle_expiry_date { get; set; }
        public string bundle_subscription_type { get; set; }
        public List<BundleDaCodes> bundle_da_codes { get; set; }
        public string bundle_id { get; set; }
        public string bundle_popular { get; set; }
        public string bundle_offer { get; set; }
        public string bundle_data_offer { get; set; }
        public string bundle_combo_offer { get; set; }
        public string product_id { get; set; }
        public string product_category_id { get; set; }
        public BundleCost bundle_cost { get; set; }
        public List<BundleRule> bundle_rule { get; set; }
        public BundleValue bundle_value { get; set; }
        public BundleValidity BundleValidity { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public PaymentOptions PaymentOptions { get; set; }
        //public DateTimeOffset Created { get; set; }
        //public DateTimeOffset Modified { get; set; }
        public string Bundle_Recurring { get; set; }
        public string Bundle_Auto_Renewable { get; set; }
    }

    public partial class BundleDaCodes
    {
        public string bundle_da_code { get; set; }

    }

    public partial class BundleCost
    {
        public string label { get; set; }
        public double value { get; set; }
        public string unit { get; set; }
        public double displayvalue { get; set; }
        public string display_name { get; set; }
    }

    public partial class BundleRule
    {
        public string rule_id { get; set; }
        public string rule_name { get; set; }
        public string rule_description { get; set; }
        public string Rule_Icon { get; set; }
    }

    public partial class BundleValidity
    {
        public string label { get; set; }
        public double value { get; set; }
        public string unit { get; set; }
        public double display_value { get; set; }
        public string display_name { get; set; }
    }

    public partial class BundleValue
    {
        public string label { get; set; }
        public double value { get; set; }
        public string unit { get; set; }
        public double display_value { get; set; }
        public string display_name { get; set; }
        public string bonus { get; set; }
        public PackageDeal[] package_deal { get; set; }
    }

    public partial class PackageDeal
    {
        public string label { get; set; }
        public double value { get; set; }
        public string unit { get; set; }
        public double display_value { get; set; }
        public string currency { get; set; }
        public string display_name { get; set; }
        public BundleRate out_of_bundle_rate { get; set; }
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
        public string product_category_name { get; set; }
        public string product_category_id { get; set; }
        public string product_category_description { get; set; }
        public string product_id { get; set; }
        public string product { get; set; }
        public FilterTab[] filter_tabs { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
    }

    public partial class FilterTab
    {
        public string filter_tab_name { get; set; }
        public string filter_criteria { get; set; }
    }



    
}
