using System.Collections.Generic;

namespace ToDo_App
{
    public class UserList
    {
        public List<User> users=new List<User>();

        public UserList()
        {
            users.Add(new User(1, "Batuhan ALTINEL"));
            users.Add(new User(2, "Yüksel IŞIK"));
            users.Add(new User(3, "Kamil ŞEN"));
            users.Add(new User(4, "Gökçe AYDIN"));

        }
    }
}