using Microsoft.AspNetCore.Builder;
using TestPlayWright;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<TestPlayWrightWebTestModule>();

public partial class Program
{
}
