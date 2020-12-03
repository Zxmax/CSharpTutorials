namespace CSharpTutorials.SOLID.Models
{
    public class PasswordReminder
    {
        public IDbConnectionInterface DbConnection { get; }

        public PasswordReminder(IDbConnectionInterface dbConnection)
        {
            DbConnection = dbConnection;
        }
    }
}