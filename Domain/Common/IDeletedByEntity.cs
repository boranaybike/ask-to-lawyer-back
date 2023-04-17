namespace Domain.Common
{
    public interface IDeletedByEntity
    {
        DateTimeOffset? DeletedOn { get; set; }
        int? DeletedByUserId { get; set; }

        bool IsDeleted { get; set; }
    }
}
