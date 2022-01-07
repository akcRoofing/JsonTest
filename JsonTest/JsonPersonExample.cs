using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  { 
  "lead_id": "TeSter-123-ABCDEFGHIJKLMNOPQRSTUVWXYZ-abcdefghijklmnopqrstuvwxyz-0123456789-AaBbCcDdEeFfGgHhIiJjKkLl",
  "user_column_data": [
    {
      "column_name": "Full Name",
      "string_value": "FirstName LastName",
      "column_id": "FULL_NAME"
    },
    {
      "column_name": "User Phone",
      "string_value": "+16505550123",
      "column_id": "PHONE_NUMBER"
    },
    {
      "column_name": "User Email",
      "string_value": "test@example.com",
      "column_id": "EMAIL"
    },
    {
      "column_name": "Postal Code",
      "string_value": "94043",
      "column_id": "POSTAL_CODE"
    },
    {
      "string_value": "Roofing",
      "column_id": "SERVICE"
    }
  ],
  "api_version": "1.0",
  "form_id": 18698608977,
  "campaign_id": 991214827,
  "google_key": "bakerGoogleWebHookValue",
  "is_test": true,
  "gcl_id": "TeSter-123-ABCDEFGHIJKLMNOPQRSTUVWXYZ-abcdefghijklmnopqrstuvwxyz-0123456789-AaBbCcDdEeFfGgHhIiJjKkLl",
  "adgroup_id": 20000000000,
  "creative_id": 30000000000
}
*/

namespace JsonTest
{
    class jsonLeadExample
    {
        public string? lead_id { get; set; }
        public List<userData>? user_column_data { get; set; }
        public string? api_version { get; set; }
        public double form_id { get; set; }
        public double campaign_id { get; set; }
        public string? google_key { get; set; }
        public bool is_test { get; set; }
        public string? gcl_id { get; set; }
        public double adgroup_id { get; set; }
        public double creative_id { get; set; }

        public class userData
        {
            public string? column_name { get; set; }
            public string? string_value { get; set; }
            public string? column_id { get; set; }


        }
        
    }
}
