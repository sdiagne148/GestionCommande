using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionComande.Web.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        [Display(Name = "Client")]
        public string? CustomerId { get; set; }
        [Display(Name = "Employé")]
        public int? EmployeeId { get; set; }
        [Display(Name = "Date de la commande")]
        public DateTime? OrderDate { get; set; }
        [Display(Name = "Date requise")]
        public DateTime? RequiredDate { get; set; }
        [Display(Name = "Date de livraison")]
        public DateTime? ShippedDate { get; set; }
        [Display(Name = "Livreur")]
        public int? ShipVia { get; set; }
        [Display(Name = "Frais de livraison")]
        public decimal? Freight { get; set; }
        [Display(Name = "Nom de l'expéditeur")]
        public string? ShipName { get; set; }
        [Display(Name = "Adresse livraison")]
        public string? ShipAddress { get; set; }
        [Display(Name = "Ville d'expédition")]
        public string? ShipCity { get; set; }
        [Display(Name = "Région d'expédition")]
        public string? ShipRegion { get; set; }
        [Display(Name = "Code postal expéditeur")]
        public string? ShipPostalCode { get; set; }
        [Display(Name = "Pays d'expédition")]
        public string? ShipCountry { get; set; }

        [Display(Name = "Employé")]
        public virtual Customer? Customer { get; set; }
        [Display(Name = "Client")]
        public virtual Employee? Employee { get; set; }
        [Display(Name = "Livreur")]
        public virtual Shipper? ShipViaNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
