namespace MyExpenses.Domain.Common;

public class BaseEntity : AuditableModel
{
    public int Id { get; protected set; }
}