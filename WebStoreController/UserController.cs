using WebStoreModel;
using WebStoreDataAccess;

namespace WebStoreController
{
    public class UserController
    {
        public int AuthenticateUser(User user)
        {
            return new UserAccess().AuthenticateUser(user);
        }
    }
}
