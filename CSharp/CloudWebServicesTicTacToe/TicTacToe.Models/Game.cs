using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Game
    {
        public Game()
        {
            this.Id = Guid.NewGuid();
            this.Board = "---------";
            this.State = GameState.WaitingForSecondPlayer;
        }
        public Guid Id { get; set; }

         [StringLength(9)]
        [Column(TypeName="char")]
        public string Board { get; set; }
        public GameState State { get; set; }

        public int FirstPlayerId { get; set; }

        public virtual User FirstPlayer { get; set; }

        [Required]
        public int SecondPlayerId { get; set; }

        public virtual User SecondPlayer { get; set; }
    }
}
