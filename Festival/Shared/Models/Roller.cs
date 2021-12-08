using System;
namespace Festival.Shared.Models
{
    public class Roller
    {
        public int rolleId { get; set; }
        public string rollenavn { get; set; }
        public int powerlvl { get; set; }


        public Roller(int rolleId, string rollenavn, int powerlvl)
        {
            this.rolleId = rolleId;
            this.rollenavn = rollenavn;
            this.powerlvl = powerlvl;

        }

        public Roller()
        {

        }
    }
}
