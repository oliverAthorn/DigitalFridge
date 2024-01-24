using System.Data;

public interface IConnectionProvider
{
    IDbConnection GetConnection();
}