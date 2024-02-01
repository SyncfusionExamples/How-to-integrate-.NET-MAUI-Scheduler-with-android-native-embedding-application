using Microsoft.Maui.Embedding;
using Android.App;
using Android.OS;
using Microsoft.Maui.Platform;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;

namespace NativeEmbedding_Scheduler
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MauiContext? _mauiContext;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder.UseMauiEmbedding<Microsoft.Maui.Controls.Application>();
            builder.ConfigureSyncfusionCore();
            MauiApp mauiApp = builder.Build();
            _mauiContext = new MauiContext(mauiApp.Services, this);

            SfScheduler scheduler = new SfScheduler();
            scheduler.View = SchedulerView.Week;
            var appointment = new ObservableCollection<SchedulerAppointment>();

            //Adding scheduler appointment in the schedule appointment collection. 
            appointment.Add(new SchedulerAppointment()
            {
                StartTime = DateTime.Today.AddHours(13),
                EndTime = DateTime.Today.AddHours(15),
                Subject = "Client Meeting",
            });

            //Adding the scheduler appointment collection to the AppointmentsSource of .NET MAUI Scheduler.
            scheduler.AppointmentsSource = appointment;
            Android.Views.View view = scheduler.ToPlatform(_mauiContext);

            // Set our view from the "main" layout resource
            SetContentView(view);
        }
    }
}