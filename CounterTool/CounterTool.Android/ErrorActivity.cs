using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace CounterTool.Droid
{
    public class ErrorActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //register error handlers
            AppDomain.CurrentDomain.UnhandledException += ErrorHandler.CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += ErrorHandler.TaskSchedulerOnUnobservedTaskException;
        }
    }
}