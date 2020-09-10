using System;

namespace WealthMaxApiClient
{
    public class ReponseObject
    {
        public int Status { get; set; }
        public int CustomerId { get; set; }
        public string[] Warnings { get; set; }
        public string[] Errors { get; set; }

    }
    public class Command
    {
        public string title{ get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string nexIBO { get; set; }
        public string martial_status { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int lead_source_id{ get; set; }
        public string gender { get; set; }
        public bool mortgage{ get; set; }
        public bool customer_isSmoker{ get; set; }
        public double annual_income{ get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
        public string selected_products { get; set; }
        public DateTime date_of_birth{ get; set; }
    }
}
