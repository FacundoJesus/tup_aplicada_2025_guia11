using GeometriaDesktop;
using GeometriaModels.DALs;
using GeometriaModels.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; //Hosting...
using Microsoft.Extensions.Options;

//host es el contenedor principal de la aplicación.
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

    #region Registro de las vistas
    services.AddTransient<Form1>();
    #endregion
})
.Build();

ApplicationConfiguration.Initialize();
var form = host.Services.GetRequiredService<Form1>(); //Va al contenedor y busa una instancia. Dame un objeto de ese tipo.
Application.Run(form);