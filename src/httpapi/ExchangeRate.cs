﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    public class ExchangeRate
    {
        [JsonProperty("ExchangeRate")]
        public Object ExchangeRateObject { get; set; }
    }
}
