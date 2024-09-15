using System;
using System.Text.Json.Serialization;

namespace AuthenBase.Models
{
    public class WeatherforcastingModel
    {
        public string Name { get; set; }
        public Main Main { get; set; }
        public Sys Sys { get; set; }

        // Constructor to initialize nested objects
        public WeatherforcastingModel()
        {
            Main = new Main();
            Sys = new Sys();
        }
    }

    public class Main
    {
        public float Temp { get; set; }
        public float feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }

    public class Sys
    {
        public string Country { get; set; }
    }
}