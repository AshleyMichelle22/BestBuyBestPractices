using System.Data;

internal class DapperDepartmetnRepository
{
    private IDbConnection conn;

    public DapperDepartmetnRepository(IDbConnection conn)
    {
        this.conn = conn;
    }

    internal object GetAllDepartments()
    {
        throw new NotImplementedException();
    }

    internal void InsertDepartment(string? userInput)
    {
        throw new NotImplementedException();
    }
}