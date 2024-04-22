namespace MohamedRefaat_TechnicalTest.Domain.Models.DomainMetadata
{
    public class BaseEntity <TEntity> 
    {
        public TEntity Id { get; set; }
    }
    public class BaseAuditedEntity<TEntity>
    {
        public TEntity Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }


}
