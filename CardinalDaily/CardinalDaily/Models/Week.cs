using System;
namespace CardinalDaily.Models
{
    public class Week
    {
        public Week()
        {
        }
        public Day Sunday { get; set; }
        public Day Monday { get; set; }
        public Day Tuesday { get; set; }
        public Day Wednesday { get; set; }
        public Day Thursday { get; set; }
        public Day Friday { get; set; }
        public Day Saturday { get; set; }
    }
}
