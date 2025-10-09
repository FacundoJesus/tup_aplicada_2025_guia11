
using GeometriaDesktop;
using GeometriaModels.DALs;
using GeometriaModels.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

var host = Host.CreateDefaultBuilder()
.ConfigureServices((context, services) =>
{
    IConfiguration configuration = context.Configuration;

    /*ejemplo
    services.Configure<ConnectionStrings>(configuration.GetSection("ConnectionStrings"));
    using Microsoft.Extensions.Options;

    public class FigurasMSQLDAL
    {
    private readonly string _connectionString;

    public FigurasMSQLDAL(IOptions<ConnectionStrings> options)
    {
        _connectionString = options.Value.DefaultConnection;
    }
    */

    #region Registro de DALs y transaccion
    services.AddSingleton<IFiguraDAL, FiguraDAL>();
    #endregion

    #region Registro de services.
    services.AddSingleton<FiguraService>();
    #endregion

    services.AddTransient<Form1>();
})
.Build();

ApplicationConfiguration.Initialize();
var form = host.Services.GetRequiredService<Form1>();
Application.Run(form);