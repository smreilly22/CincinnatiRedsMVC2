using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincinnatiRedsData
{
    public class GameInfo
    {
        [Key]
        public int GameId { get; set; }



        [Required]
        [Range(0, int.MaxValue)]
        public int RedScore { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int OtherTeamScore { get; set; }

        [Required]
        public double Innings { get; set; }

        [ForeignKey(nameof(Season))]
       
        public int SeasonYear { get; set; }

        public virtual Season Season { get; set; }

        public bool ExtraInnings
        {
            get
            {
                if (Innings > 9)
                    return true;
                return false;
            }

        }

        public bool HomeOrAway { get; set; }
    }
}
