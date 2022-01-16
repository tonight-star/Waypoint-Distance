using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Device.Location;

namespace WaypointDistance
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		public void initialAppState(){
			waypoint1LatTB.Text = "";
			waypoint1LongTB.Text = "";
			waypoint2LatTB.Text = "";
			waypoint2LongTB.Text = "";
			
			distanceLabel.Text = "-";
			bearingLabel.Text = "-";
			timeLabel.Text = "-";
			constantLabel.Visible = false;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			initialAppState();
		}
		
		public double stringToDouble(string s)
		{
			if(s.Contains("."))
			{
			   	s.Replace(".",",");
			}
			   return Convert.ToDouble(s);
		}
		
		public class AngleConverter
		{
		   public double ConvertDegreesToRadians(double angle)
		   {
		      return Math.PI * angle / 180.0;
		   }	
		
		   public double ConvertRadiansToDegrees(double angle)
		   {
		      return 180.0 * angle / Math.PI;
		   }
		}
		
		public string SecondToHHMMSS(int s)
		{
			int hour = s / 3600;
			s %= 3600;
			
			int minute = s / 60;
			s %= 60;
			
			int second = s;
			
			return (hour.ToString() + "h " + minute.ToString() + "m " + second.ToString() + "s");
		}
		
		public void calculateDistance(GeoCoordinate a, GeoCoordinate b)
		{
			double distance = a.GetDistanceTo(b) / 1000;
			distanceLabel.Text = distance.ToString();
		}
		
		public void calculateBearing(GeoCoordinate a, GeoCoordinate b)
		{
			AngleConverter converter = new AngleConverter();
			var lat1 = converter.ConvertDegreesToRadians(a.Latitude);
			var long1 = converter.ConvertDegreesToRadians(a.Longitude);
			var lat2 = converter.ConvertDegreesToRadians(b.Latitude);
			var long2 = converter.ConvertDegreesToRadians(b.Longitude);
			
			var dLon = long1 - long2;
			
			var y = Math.Sin(dLon) * Math.Cos(lat2);
			var x = Math.Cos(lat1) * Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(lat2) * Math.Cos(dLon);
			var theta = Math.Atan2(y, x);
			
			double bearing = (converter.ConvertRadiansToDegrees(theta) + 360) % 360;
			bearingLabel.Text = bearing.ToString();
		}
		
		public void calculateTime(GeoCoordinate a, GeoCoordinate b)
		{
			double v = 1.02888889; // meter per second, or 2 knot
			double s = a.GetDistanceTo(b);
			double t = s / v;
			
			string time = SecondToHHMMSS(Convert.ToInt32(t));		
			
			timeLabel.Text = time;
			constantLabel.Visible = true;
		}
		
		void CalculateButtonClick(object sender, EventArgs e)
		{
			double temp;
			
			if(string.IsNullOrEmpty(waypoint1LatTB.Text) || string.IsNullOrEmpty(waypoint1LongTB.Text) 
			   || string.IsNullOrEmpty(waypoint2LatTB.Text) || string.IsNullOrEmpty(waypoint2LongTB.Text))
			{
				MessageBox.Show("Please fill the blank input!");
			}
			else if(double.TryParse(waypoint1LatTB.Text, out temp) && double.TryParse(waypoint1LongTB.Text, out temp) 
			        && double.TryParse(waypoint2LatTB.Text, out temp) && double.TryParse(waypoint2LongTB.Text, out temp))
			{
				double waypoint1Lat = stringToDouble(waypoint1LatTB.Text);
				double waypoint1Long = stringToDouble(waypoint1LongTB.Text);
				double waypoint2Lat = stringToDouble(waypoint2LatTB.Text);
				double waypoint2Long = stringToDouble(waypoint2LongTB.Text);
				
				GeoCoordinate waypoint1 = new GeoCoordinate(waypoint1Lat, waypoint1Long);
				GeoCoordinate waypoint2 = new GeoCoordinate(waypoint2Lat, waypoint2Long);
				
				calculateDistance(waypoint1, waypoint2);
				calculateBearing(waypoint1, waypoint2);
				calculateTime(waypoint1, waypoint2);
			}
			else{
				MessageBox.Show("Please input numerical value!");
			}
		}
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			initialAppState();
		}
		
	}
}
