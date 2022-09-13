using securedDataStoreage.DataBase;

namespace securedDataStoreage.Functions;

public class UserFunctions
{
    private readonly ApplicationDbContext _context;
    
    public UserFunctions(ApplicationDbContext context)
    {
        _context = context;
    }
    public void CreateUser(UserDTO newUser)
    {
        // _context.Users.Add(newUser);
        // await _context.SaveChangesAsync();
    } 
}

//How and Where are the DTO's defined
// Is context here nesessary?