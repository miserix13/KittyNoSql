using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NoSqlWrapper.Data.Entity
{
    [Table("Store")]
    public class StoreEntity : IStoreEntity
    {
        [Key()]
        [Column(Order=0)]
        public Guid StoreId { get; set; }
        public Guid TypeVersionId { get; set; }

        [Required]
        public string Value { get; set; }

        public DateTime DateCreated
        {
            get;
            set;
        }
        public DateTime LastUpdated
        {
            get;
            set;
        }

        public TypeVersionEntity TypeVersion { get; set; }
    }
}
