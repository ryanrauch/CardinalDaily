using CardinalDaily.ViewModels;
using Xamarin.Forms.Xaml;

namespace CardinalDaily.Views.ContentPages
{
    public class InitialViewBase : ViewPageBase<InitialViewModel> { }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InitialView : InitialViewBase
	{
		public InitialView ()
		{
			InitializeComponent ();
		}
	}
}