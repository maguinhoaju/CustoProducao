using System.Security.Principal;

namespace CustoProducao.Core.Interfaces
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
