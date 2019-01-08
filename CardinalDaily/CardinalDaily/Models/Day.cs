using System;
namespace CardinalDaily.Models
{
    public class Day
    {
        public Day()
        {
            _set = false;
        }

        public Day(Boolean value)
        {
            Value = value;
            _set = true;
        }

        private Boolean _set { get; set; }
        public Boolean HasBeenSet => _set;

        public Boolean Value { get; set; }

        public String DisplayShort => _set ? Value ? "1" : "0" 
                                           : "";
    }
}
