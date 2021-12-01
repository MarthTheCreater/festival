using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival.Shared.Models
{
    public class Koordinator : Bruger
    {
        public int koordinatorId { get; set; }

        public Koordinator(int koordinatorId)
        {
            this.koordinatorId = koordinatorId;
        }
    }
}
