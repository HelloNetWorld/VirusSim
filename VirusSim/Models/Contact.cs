using System;
using Newtonsoft.Json;

namespace VirusSim.Models
{
    public class Contact
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Member1_ID { get; set; }
        public int Member2_ID { get; set; }
    }
}
