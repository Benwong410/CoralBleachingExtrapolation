using Azure.Core.GeoJson;
using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;
using NetTopologySuite.Algorithm;
using CoralBleachingExtrapolation.Data;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// 03-02-2025  1.0     Keelin   Point GBR Implimenting UML (GBRCoral.cs) 
/// 03-02-2025  1.0.1   Keelin   Fixing references and errors (InvalidOperationException, InvalidColumnName) 
/// </summary>
/// 

namespace CoralBleachingExtrapolation.Models
{
    //public class MedianLiveCoral
    //{
    //    [Key]
    //    public int MedianLiveCoral_ID { get; set; }
    //    public string? Median { get; set; }
    //}


    //public class MedianDeadCoral
    //{
    //    [Key]
    //    public int MedianDeadCoral_ID { get; set; }
    //    public string? Median { get; set; }

    //}


    //public class MedianSoftCoral
    //{
    //    [Key]
    //    public int MedianSoftCoral_ID { get; set; }
    //    public string? Median { get; set; }
    //}

    //public class GBRCoralProperties
    //{
    //    [Key]
    //    public int GBRCoralPropertiesID { get; set; }
    //    public string? MeanLiveCoral { get; set; }
    //    public string? MeanSoftCoral { get; set; }
    //    public string? MeanDeadCoral { get; set; }
    //    public MedianLiveCoral? MedianLiveCoralFK { get; set; }
    //    public MedianSoftCoral? MedianSoftCoralFK { get; set; }
    //    public MedianDeadCoral? MedianDeadCoralFK { get; set; }
    //}

    public class GBRCoralPoint
    {
        [Key]
        public int GBRCoralPointID { get; set; }
        public string? ReefName { get; set; }
        public Point? Point { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? ReportYear { get; set; }
        [Required]
        public int? GBRCoralPropertiesFK { get; set; }
        //public GBRCoralProperties? GBRCoralPropertiesFK { get; set; }
    }

}
