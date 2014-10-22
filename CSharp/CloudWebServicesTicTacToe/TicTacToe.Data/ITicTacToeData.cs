using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Data.Repositories;
using TicTacToe.Models;

namespace TicTacToe.Data
{
   public  interface ITicTacToeData
    {
       IRepository<User> Users { get;}

       IRepository<Game> Games { get; }

       int SaveChanges();
    }
}
