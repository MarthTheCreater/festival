using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Shared.Models
{
    public class Frivillige : Bruger
    {

        public int frivilligId { get; set; }
        public string inviId { get; set; }

        public Frivillige(int frivilligId, string inviId)
        {
            this.frivilligId = frivilligId;
            this.inviId = inviId;
        }
    }
}
