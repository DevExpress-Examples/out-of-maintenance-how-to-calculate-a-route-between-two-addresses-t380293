﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CalculateRoutesByAddresses {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e) {

            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();
        }
    }
}
