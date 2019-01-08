using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CardinalDaily.Models;

namespace CardinalDaily.ViewModels
{
    public class InitialViewModel : ViewModelBase
    {
        public InitialViewModel()
        {
            //List<DayModel> days = new List<DayModel>();
            //days.Add(new DayModel(true));
            //days.Add(new DayModel(false));
            //days.Add(new DayModel(false));
            //Days = days;

            ////////
            WeekCalendarTest = new Week();
            WeekCalendarTest.Sunday = new Day(true);
            WeekCalendarTest.Monday = new Day(false);
            WeekCalendarTest.Tuesday = new Day(true);
            WeekCalendarTest.Wednesday = new Day(true);
            WeekCalendarTest.Thursday = new Day(false);
            WeekCalendarTest.Friday = new Day(true);
            WeekCalendarTest.Saturday = new Day(true);
            //RaisePropertyChanged(() => WeekCalendarTest);
            YearCalendarTest = new List<Week>();
            YearCalendarTest.Add(WeekCalendarTest);
            for(int i = 0; i < 52; ++i)
            {
                YearCalendarTest.Add(WeekCalendarTest);
            }
        }

        //private List<DayModel> _days { get; set; }
        //public List<DayModel> Days
        //{
        //    get { return _days; }
        //    set
        //    {
        //        _days = value;
        //        RaisePropertyChanged(() => Days);
        //    }
        //}

        //private DayModel _daySelectedItem { get; set; }
        //public DayModel DaySelectedItem
        //{
        //    get { return _daySelectedItem; }
        //    set
        //    {
        //        _daySelectedItem = value;
        //        RaisePropertyChanged(() => DaySelectedItem);
        //    }
        //}

        public Week WeekCalendarTest { get; set; }
        public List<Week> YearCalendarTest { get; set; }

        public override Task OnAppearingAsync()
        {
            return Task.CompletedTask;
        }
    }
}
