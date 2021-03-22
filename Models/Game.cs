using System;
using System.ComponentModel.DataAnnotations;

namespace razor_pg_ef.Models
{

    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }


}
