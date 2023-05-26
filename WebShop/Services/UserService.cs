//using Microsoft.EntityFrameworkCore;
//using WebShop.Contexts;
//using WebShop.Models.Entities;

//namespace WebShop.Services;

//public class UserService
//{


//    private readonly WebAppContext _identityContext;

//    public UserService(WebAppContext identityContext)
//    {
//        _identityContext = identityContext;
//    }

//    public async Task<AppUserEntity> GetUserProfileAsync(string userId)
//    {
//        var userProfileEntity = await _identityContext.UserProfiles.Include(x => x.User).FirstOrDefaultAsync(x => x.UserId == userId);
//        return userProfileEntity!;
//    }
//}
