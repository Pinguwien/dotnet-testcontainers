namespace DotNet.Testcontainers.Containers.Modules.Abstractions
{
  using Configurations;

  public abstract class TestContainerKeycloak : HostedServiceContainer
  {
    protected TestContainerKeycloak(ITestcontainersConfiguration configuration) : base(configuration)
    {
    }

  }
}
