<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571187/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T380293)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/CalculateRoutesByAddresses/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CalculateRoutesByAddresses/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/CalculateRoutesByAddresses/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CalculateRoutesByAddresses/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Calculate a Route Between Two Addresses


This example demonstrates how to calculate a route between two addresses.


<h3>Description</h3>

To send a route request, use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutetopic">BingRouteDataProvider.CalculateRoute</a> method. This method receives a list of <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapRouteWaypointtopic">RouteWaypoint</a> objects as a parameter. Note that <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapRouteWaypointtopic">RouteWaypoint</a> objects are created using the constructor that receives the waypoint description and a keyword that is used to search a location on a map.

<br/>


