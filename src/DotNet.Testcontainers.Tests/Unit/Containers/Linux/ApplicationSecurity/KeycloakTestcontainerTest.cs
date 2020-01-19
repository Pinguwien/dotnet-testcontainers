namespace DotNet.Testcontainers.Tests.Unit.Containers.Linux.ApplicationSecurity
{
  using System.Threading.Tasks;
  using Testcontainers.Containers.Builders;
  using Testcontainers.Containers.Modules;
  using Testcontainers.Containers.Modules.ApplicationSecurity;
  using Xunit;

  public class KeycloakTestcontainerTest
  {
    [Fact]
    public async Task startKeycloakAndReturnServerInfo()
    {
      //TODO: First: Make it work with generic. Then: implement & change to KeycloakContainer
      var keycloakTestcontainer = new TestcontainersBuilder<TestcontainersContainer>()
        .WithEnvironment("KEYCLOAK_USER", "admin")
        .WithEnvironment("KEYCLOAK_PASSWORD", "admin")
        .WithEnvironment("KEYCLOAK_IMPORT", "TODO");
    }
  }
}
