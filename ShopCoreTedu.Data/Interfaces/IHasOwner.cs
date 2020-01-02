namespace ShopCoreTedu.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; } 
    }
}
