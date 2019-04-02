﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace binance.dex.sdk.httpapi
{
    public class ValidatorInfo
    {
        public string address;

        [JsonProperty("pub_key")]
        public List<int> PubKey { get; set; }

        [JsonProperty("voting_power")]
        public long VotingPower { get; set; }
    }

    public class Validator
    {
        [JsonProperty("block_height")]
        public long BlockHeight { get; set; }

        [JsonProperty("validators")] 
        public List<ValidatorInfo> Validators { get; set; }
    }
}
