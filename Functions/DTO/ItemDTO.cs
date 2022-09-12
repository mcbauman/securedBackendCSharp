namespace securedDataStoreage.DataBase;

public class ItemDTO
{
    public Guid? Id { get; set; }
    public List<Guid> UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}