//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class AdminerBuilderExtensions
    {
        public static ApplicationModel.IResourceBuilder<ApplicationModel.AdminerContainerResource> AddAdminer(this IDistributedApplicationBuilder builder, string name, int? port = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.AdminerContainerResource> WithHostPort(this ApplicationModel.IResourceBuilder<ApplicationModel.AdminerContainerResource> builder, int? port) { throw null; }
    }
}

namespace Aspire.Hosting.ApplicationModel
{
    public sealed partial class AdminerContainerResource : ContainerResource
    {
        public AdminerContainerResource(string name) : base(default!, default) { }

        public EndpointReference PrimaryEndpoint { get { throw null; } }
    }
}