using System;
namespace CardinalDaily.Models
{
    public class Day
    {
        public Day()
        {
            Value = false;
        }

        public Day(Boolean value)
        {
            Value = value;
        }

        public Boolean Value { get; set; }
    }
}
