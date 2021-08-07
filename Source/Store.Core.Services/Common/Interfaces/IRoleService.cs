using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Store.Core.Contracts.Models;
using Store.Core.Contracts.Responses;
using Store.Core.Services.Roles.Queries.CreateRole;
using Store.Core.Services.Roles.Queries.GetActions;

namespace Store.Core.Common.Interfaces
{
    public interface IRoleService
    {
        Task<List<Role>> GetRolesAsync(CancellationToken cts);
        Task<Role> GetRoleAsync(Guid id, CancellationToken cts);
        Task CreateRoleAsync(CreateRoleCommand request, Guid id, string[] actions, CancellationToken cts);
        Task UpdateRoleAsync(Role model, CancellationToken cts);
        Task DisableRoleAsync(Guid id, CancellationToken cts);
        Task DeleteRoleAsync(Guid id, CancellationToken cts);
    }
}