using System;
using System.Collections.Generic;
using System.Text;

namespace BitCoinCalculator
{
    public class BitCoinRates
    {
        public bpi bpi { get; set; }
        
    }
    public class bpi
    {
        public EUR EUR { get; set; }
        public USD USD { get; set; }
        public GBP GBP { get; set; }
    }

    
    public class USD
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }

    public class EUR
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }

    public class GBP
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
}
