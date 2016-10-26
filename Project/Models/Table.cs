namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WeekNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string Team1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Team2 { get; set; }

        [Required]
        [StringLength(10)]
        public string GameName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Team1Score { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Team2Score { get; set; }
    }
}
