using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace SecurityApi.Policies
{
    public class IdadeMinima:IAuthorizationRequirement
    {
        public IdadeMinima(int idade)=>Idade= idade;

        public int Idade { get; }
    }
}
