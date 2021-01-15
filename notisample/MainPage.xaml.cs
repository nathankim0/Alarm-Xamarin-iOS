using notisample.AppInterfaces;
using Xamarin.Forms;

namespace notisample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
                //Alarm set.
                //iOS - Notification Framework (version 10 and above).
                DependencyService.Get<ILocalNotification>().ShowNotification("title example",
                                                                            "subtitle example",
                                                                            "description example",
                                                                            "",
                                                                            _timePicker.Time.ToString(),
                                                                            0,
                                                                            "");
        }
    }
}
