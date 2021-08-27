﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectB.deserialize.HotelDetailsFromJSON
{
    public class Address
    {
        public string CountryName { get; set; }

        public string CityName { get; set; }

        public string PostalCode { get; set; }

        public string ProvinceName { get; set; }

        public string AddressLine1 { get; set; }

        public string CountryCode { get; set; }

        [JsonIgnore]
        public string Pattern { get; set; }

        public string FullAddress { get; set; }
    }
}
