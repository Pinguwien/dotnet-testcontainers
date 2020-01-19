namespace DotNet.Testcontainers.Containers.Configurations.Abstractions
{
  using Modules.Abstractions;
  using Services;

  public abstract class TestcontainerKeycloakConfiguration : HostedServiceConfiguration
  {
    //TODO: Add keycloak-specfics
    protected TestcontainerKeycloakConfiguration(string image, int defaultPort) : base(image, defaultPort, TestcontainersNetworkService.GetAvailablePort())
    {
    }
  }
}
