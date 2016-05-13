using System;

namespace RepositoryEngine.data
{
    public class User : IUser
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public EUserPermission UserPermission { get; set; }
    }
}