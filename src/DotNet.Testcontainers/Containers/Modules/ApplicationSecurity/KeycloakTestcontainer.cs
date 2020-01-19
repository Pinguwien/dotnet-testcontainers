namespace DotNet.Testcontainers.Containers.Modules.ApplicationSecurity
{
  using Abstractions;
  using Configurations;

  public class KeycloakTestcontainer : TestContainerKeycloak
  {
    public KeycloakTestcontainer(ITestcontainersConfiguration configuration) : base(configuration)
    {
    }

    public override string ConnectionString { get; }
  }
}
