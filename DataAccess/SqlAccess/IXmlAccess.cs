namespace DataAccess.SqlAccess
{
    public interface IXmlAccess
    {
        void CreateXmlFileIfNotExists(string connectionString);
        string ReadConnectionString();
    }
}