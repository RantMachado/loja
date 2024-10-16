using AutoFixture;

namespace Loja.Tests._Helpers;

public abstract class BaseTest
{
  protected Fixture _fixture;

  protected BaseTest() => _fixture = new();
}
