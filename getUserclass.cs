using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace NCSeLibraryMVC
{
  //  public static class getUserclass
    public static class ExtensionMethods
    {
        public static string getUserId(this ClaimsPrincipal user)

        {
            if(!user.Identity.IsAuthenticated)
            {
                return null;
            }
            ClaimsPrincipal currentUser = user;
            return currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

        }
    }
}
