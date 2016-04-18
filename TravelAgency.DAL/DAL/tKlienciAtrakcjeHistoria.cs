namespace TravelAgency.DAL.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TravelAgency.DAL.Util;

    [Table("tKlienciAtrakcjeHistoria")]
    public partial class tKlienciAtrakcjeHistoria
    {
        public int IDKlienta { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDAtrakcjiUslugi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDOsobyAtrakcji { get; set; }

        [Display(Name = "PaymentManner", ResourceType = typeof(Strings))]
        [Required]
        [StringLength(7)]
        public string SposobZaplaty { get; set; }

        [Display(Name = "PaymentDate", ResourceType = typeof(Strings))]
        public DateTime DataZaplaty { get; set; }

        [Display(Name = "PaidAmount", ResourceType = typeof(Strings))]
        [Column(TypeName = "money")]
        public decimal? ZaplaconaKwota { get; set; }

        public virtual tAtrakcjeHistoria tAtrakcjeHistoria { get; set; }

        public virtual tKlient tKlient { get; set; }

        public virtual tOsoby tOsoby { get; set; }
    }
}
