namespace TicTacToe.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using TicTacToe.Models;
   using TicTacToe.Data.Migrations;


    public class TicTacToeDbContext : IdentityDbContext<User>
    {
        public TicTacToeDbContext()
            : base("TicTacToe", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TicTacToeDbContext, Configuration>()); 
        }

        public static TicTacToeDbContext Create()
        {
            return new TicTacToeDbContext();
        }
    }
}
