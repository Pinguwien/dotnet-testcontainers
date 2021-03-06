namespace DotNet.Testcontainers.Tests.Unit.Containers.Linux.Database
{
  using System;
  using System.Threading.Tasks;
  using DotNet.Testcontainers.Containers.Builders;
  using DotNet.Testcontainers.Containers.Configurations.Databases;
  using DotNet.Testcontainers.Containers.Modules.Databases;
  using StackExchange.Redis;
  using Xunit;

  public class RedisTestcontainerTest
  {
    [Fact]
    public async Task ConnectionEstablished()
    {
      // Given
      var testcontainersBuilder = new TestcontainersBuilder<RedisTestcontainer>()
        .WithDatabase(new RedisTestcontainerConfiguration()); // TODO: Until now the configuration is not applied by `RedisTestcontainerConfiguration`. Use `WithCommand` or mount redis.conf instead.

      // When
      // Then
      await using (var testcontainer = testcontainersBuilder.Build())
      {
        await testcontainer.StartAsync();

        using (var connection = ConnectionMultiplexer.Connect(testcontainer.ConnectionString))
        {
          Assert.True(connection.GetServer(testcontainer.Hostname, testcontainer.Port).Ping().Milliseconds > 0, "Cannot connect to Redis Testcontainer.");
        }
      }
    }

    [Fact]
    public void CannotSetDatabase()
    {
      var redis = new RedisTestcontainerConfiguration();
      Assert.Throws<NotImplementedException>(() => redis.Database = string.Empty);
    }

    [Fact]
    public void CannotSetUsername()
    {
      var redis = new RedisTestcontainerConfiguration();
      Assert.Throws<NotImplementedException>(() => redis.Username = string.Empty);
    }

    [Fact]
    public void CannotSetPassword()
    {
      var redis = new RedisTestcontainerConfiguration();
      Assert.Throws<NotImplementedException>(() => redis.Password = string.Empty);
    }
  }
}
