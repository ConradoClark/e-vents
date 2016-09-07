using Eventos.Model.Base;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Model.Events
{
    [Table("Event")]
    public class Event : BaseModel
    {
        // ---------------------------------
        // Basic Information
        // ---------------------------------

        [Column("id")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        // ---------------------------------
        // Pricing
        // ---------------------------------

        [Column("eventPricingModel")]
        public int PricingModel { get; set; }

        [Column("eventPrice")]
        public decimal EventPrice { get; set; }

        [Column("eventCustomPrice")]
        public string CustomPrice { get; set; }

        // ---------------------------------
        // Schedule
        // ---------------------------------

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("isReocurring")]
        public bool IsReocurring { get; set; }

        [Column("eventFrequency")]
        public TimeSpan Frequency { get; set; }

        [Column("eventCustomFrequency")]
        public string CustomFrequency { get; set; }

        // ---------------------------------
        // Location
        // ---------------------------------
        [Column("addressLine1")] // rua
        public string AddressLine1 { get; set; }

        [Column("addressLine2")] // numero
        public string AddressLine2 { get; set; }

        [Column("addressLine3")] // apto / bloco / referencia / etc
        public string AddressLine3 { get; set; }

        [Column("addressLine4")] // bairro
        public string AddressLine4 { get; set; }

        [Column("locality")] // cidade
        public string LocalityId { get; set; }

        [Column("region")] // estado
        public string RegionId { get; set; }

        [Column("zipCode")] // cep
        public string ZipCode { get; set; }

        [Column("countryId")] // país
        public int CountryId { get; set; }

        // ---------------------------------
        // Discovery
        // ---------------------------------
        [Column("eventTags")]
        public string Tags { get; set; }
    }
}
