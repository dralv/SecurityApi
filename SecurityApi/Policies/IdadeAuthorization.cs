using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace SecurityApi.Policies
{
    public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
        {
            var dataDeNascimentoClaim = context.User.FindFirst(c => c.Type ==ClaimTypes.DateOfBirth);

            if(dataDeNascimentoClaim is null) return Task.CompletedTask;

            var dataDeNascimento = Convert.ToDateTime(dataDeNascimentoClaim.Value);

            int idade = DateTime.Today.Year - dataDeNascimento.Year;

            if (dataDeNascimento > DateTime.Today.AddYears(-idade)) idade--;

            if(idade>=requirement.Idade)  context.Succeed(requirement);

            return Task.CompletedTask;

        }
    }
}
