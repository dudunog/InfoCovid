using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace InfoCovid.Models
{
  public class Rootobject
  {
    [JsonProperty("Message")]
    public string Message { get; set; }

    [JsonProperty("Global")]
    public Global Global { get; set; }

    [JsonProperty("Countries")]
    public Country[] Countries { get; set; }
    [JsonProperty("Date")]
    public DateTime Date { get; set; }
  }

  public class Global
  {
    [JsonProperty("NewConfirmed")]
    public int NewConfirmed { get; set; }

    [JsonProperty("TotalConfirmed")]
    [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
    public int TotalConfirmed { get; set; }

    [JsonProperty("NewDeaths")]
    public int NewDeaths { get; set; }

    [JsonProperty("TotalDeaths")]
    public int TotalDeaths { get; set; }

    [JsonProperty("NewRecovered")]
    public int NewRecovered { get; set; }

    [JsonProperty("TotalRecovered")]
    public int TotalRecovered { get; set; }
  }
  public class Country
  {
    [JsonProperty("Country")]
    public string Name { get; set; }

    [JsonProperty("CountryCode")]
    public string CountryCode { get; set; }

    [JsonProperty("Slug")]
    public string Slug { get; set; }

    [JsonProperty("NewConfirmed")]
    public int NewConfirmed { get; set; }

    [JsonProperty("TotalConfirmed")]
    public int TotalConfirmed { get; set; }

    [JsonProperty("NewDeaths")]
    public int NewDeaths { get; set; }

    [JsonProperty("TotalDeaths")]
    public int TotalDeaths { get; set; }

    [JsonProperty("NewRecovered")]
    public int NewRecovered { get; set; }

    [JsonProperty("TotalRecovered")]
    public int TotalRecovered { get; set; }

    [JsonProperty("Date")]
    public DateTime Date { get; set; }

    [JsonProperty("Premium")]
    public Premium Premium { get; set; }
  }

  public class Premium
  {
  }
}