Imports DevExpress.Xpf.Map
Imports System.Collections.Generic
Imports System.Windows

Namespace CalculateRoutesByAddresses
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            routeProvider.CalculateRoute(New List(Of RouteWaypoint) From { _
                New RouteWaypoint("New York", "Belmont Park, New York, USA"), _
                New RouteWaypoint("Las Vegas", "Lorenzi Park, Las Vegas, USA") _
            })
        End Sub

        Private Sub OnRouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)
            Dim box As SearchBoundingBox = e.CalculationResult.RouteResults(0).BoundingBox
            Dim topLeft As GeoPoint = New GeoPoint With {.Latitude = box.NorthLatitude, .Longitude = box.WestLongitude}
            Dim bottomRight As GeoPoint = New GeoPoint With {.Latitude = box.SouthLatitude, .Longitude = box.EastLongitude}
            mapControl.ZoomToRegion(topLeft, bottomRight, 0.4)
            waitIndicator.DeferedVisibility = False
        End Sub
    End Class
End Namespace
