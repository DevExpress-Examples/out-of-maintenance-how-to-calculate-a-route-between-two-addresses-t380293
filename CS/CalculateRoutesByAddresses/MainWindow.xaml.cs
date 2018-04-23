using DevExpress.Xpf.Map;
using System.Collections.Generic;
using System.Windows;

namespace CalculateRoutesByAddresses {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e) {
            routeProvider.CalculateRoute(new List<RouteWaypoint> {
                new RouteWaypoint("New York", "Belmont Park, New York, USA"),
                new RouteWaypoint("Las Vegas", "Lorenzi Park, Las Vegas, USA")
            });
        }

        private void OnRouteCalculated(object sender, BingRouteCalculatedEventArgs e) {
            SearchBoundingBox box = e.CalculationResult.RouteResults[0].BoundingBox;
            GeoPoint topLeft = new GeoPoint {
                Latitude = box.NorthLatitude,
                Longitude = box.WestLongitude
            };
            GeoPoint bottomRight = new GeoPoint {
                Latitude = box.SouthLatitude,
                Longitude = box.EastLongitude
            };
            mapControl.ZoomToRegion(topLeft, bottomRight, 0.4);
            waitIndicator.DeferedVisibility = false;
        }
    }
}
