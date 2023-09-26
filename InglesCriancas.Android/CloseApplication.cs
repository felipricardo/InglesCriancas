using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesCriancas.Droid
{
    class CloseApplication: ICloseApplication
    {
        public void closeApplication()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }

        void ICloseApplication.CloseApplication()
        {
            throw new NotImplementedException();
        }
    }
}