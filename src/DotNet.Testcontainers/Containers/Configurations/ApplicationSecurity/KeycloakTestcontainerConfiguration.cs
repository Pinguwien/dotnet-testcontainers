namespace DotNet.Testcontainers.Containers.Configurations.ApplicationSecurity
{
  using System.Security.Cryptography;
  using Abstractions;
  using WaitStrategies;

  public sealed class KeycloakTestcontainerConfiguration : TestcontainerKeycloakConfiguration
  {
    public KeycloakTestcontainerConfiguration() : base("jboss/keycloak:8.0.1", 8080)
    {
    }
  //TODO: Fill with KeycloakSpecifics.
    public override IWaitUntil WaitStrategy => this.CreateWaitStrategy();

    private IWaitUntil CreateWaitStrategy()
    {
      //TODO: Perhaps implement HttpStrategy (but may be a bunch of work)
      return Wait.UntilMessagesAreLogged(null, "Keycloak 8.0.1 (WildFly Core 10.0.3.Final) started in");
    }
  }
}
