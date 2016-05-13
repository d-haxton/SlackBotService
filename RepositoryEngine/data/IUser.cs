using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.data
{
    public interface IUser
    {
        Guid Id { get; set; }
        string Username { get; set; }
        EUserPermission UserPermission { get; set; }
    }

    public enum EUserPermission
    {
        User,
        Moderator,
        Administrator
    }
}
