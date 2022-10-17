
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace RestFul.models
{
    public class Meta
    {
        public int Code { get; set; }
        public int RequestId { get; set; }
    }
    public class LabeledLatLng
    {
        public string label { get; set; }
        public int Lat { get; set; }
        public int Lng { get; set; }
    }
    public class Location
    {
        public string Address { get; set; }
        public string CrossStreet { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public List<LabeledLatLng> LabeledLatLngs { get; set; }
        public int Distance { get; set; }
        public string Postalcode { get; set; }
        public string Cc { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public List<string> FormattedAddress { get; set; }
    }
    public class Icon
    {
        public string Prefix { get; set; }
        public string Suffix { get; set; }
    }
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public string ShortName { get; set; }
        public Icon Icon { get; set; }
        public bool Primary { get; set; }
    }
    public class VenuePage
    {
        public string Id { get; set; }
    }
    public class Venue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public List<Category> Categories { get; set; }
        public VenuePage VenuePage { get; set; }
    }
    public class Response
    {
        public ObservableCollection<Venue> Venues { get; set; }
    }
    public class Place
    {
        public Meta Meta { get; set; }
        public Response Response { get; set; }
    }
}
