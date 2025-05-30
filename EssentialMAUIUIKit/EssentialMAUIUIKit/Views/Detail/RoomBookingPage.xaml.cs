using Syncfusion.Maui.Toolkit.Calendar;
using System.Globalization;

namespace EssentialMAUIUIKit.Views.Detail
{
    public partial class RoomBookingPage : ContentView
    {
        public RoomBookingPage()
        {
            InitializeComponent();
        }

        private void SfCalendar_ActionButtonClicked(object sender, Syncfusion.Maui.Toolkit.Calendar.CalendarSubmittedEventArgs e)
        {
            CalendarDateRange? dateRange = e.Value as CalendarDateRange;
            if (dateRange != null)
            {
                if (dateRange.EndDate == null)
                {
                    this.viewModel.RoomDetail!.SelectedRanges = $"{dateRange.StartDate:dd MMM yyyy}";
                }
                else
                {
                    this.viewModel.RoomDetail!.SelectedRanges = $"{dateRange.StartDate:dd MMM yyyy} - {dateRange.EndDate:dd MMM yyyy}";
                }
#if WINDOWS || MACCATALYST
                sfComboBox.Text = this.viewModel.RoomDetail!.SelectedRanges;
                sfComboBox.IsDropDownOpen = false;
#else
                sfComboBoxMobile.Text = this.viewModel.RoomDetail!.SelectedRanges;
                sfComboBoxMobile.IsDropDownOpen = false;
#endif
            }

        }
    }
}