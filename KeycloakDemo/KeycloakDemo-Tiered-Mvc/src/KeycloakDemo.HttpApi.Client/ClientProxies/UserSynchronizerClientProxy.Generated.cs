// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using KeycloakDemo.Oidc;

// ReSharper disable once CheckNamespace
namespace KeycloakDemo.Oidc.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IUserSynchronizerAppService), typeof(UserSynchronizerClientProxy))]
public partial class UserSynchronizerClientProxy : ClientProxyBase<IUserSynchronizerAppService>, IUserSynchronizerAppService
{
    public virtual async Task SyncAsync(SyncInputDto input)
    {
        await RequestAsync(nameof(SyncAsync), new ClientProxyRequestTypeValue
        {
            { typeof(SyncInputDto), input }
        });
    }
}
