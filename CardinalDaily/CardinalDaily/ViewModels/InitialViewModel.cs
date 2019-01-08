using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CardinalDaily.Models;
using CardinalDaily.Services.Interfaces;

namespace CardinalDaily.ViewModels
{
    public class InitialViewModel : ViewModelBase
    {
        private readonly ISecureStorageService _secureStorageService;

        public InitialViewModel(ISecureStorageService secureStorageService)
        {
            _secureStorageService = secureStorageService;

            WeekCalendarTest = new Week();
            WeekCalendarTest.Sunday = new Day(true);
            WeekCalendarTest.Monday = new Day(false);
            WeekCalendarTest.Tuesday = new Day(true);
            WeekCalendarTest.Wednesday = new Day(true);
            WeekCalendarTest.Thursday = new Day(false);
            WeekCalendarTest.Friday = new Day();
            WeekCalendarTest.Saturday = new Day();

            YearCalendarTest = new List<Week>();
            YearCalendarTest.Add(WeekCalendarTest);
            for(int i = 0; i < 52; ++i)
            {
                YearCalendarTest.Add(WeekCalendarTest);
            }
        }

        public Week WeekCalendarTest { get; set; }

        public List<Week> YearCalendarTest { get; set; }

        public override Task OnAppearingAsync()
        {
            return Task.CompletedTask;
        }
    }
}
