using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

public class ConnectionProvider : IConnectionProvider
{
    private readonly IConfiguration _configuration;

    public ConnectionProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IDbConnection GetConnection()
    {
        return new SqlConnection(
            _configuration.GetConnectionString("DefaultConnection"));
    }
}

