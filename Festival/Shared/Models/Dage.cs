using System;
namespace Festival.Shared.Models
{
    public class Dage
    {
        public int dageId { get; set; }
        public int ugedage { get; set; }


        public Dage(int dageId, int ugedage)
        {
            this.dageId = dageId;
            this.ugedage = ugedage;
        
        }

        public Dage()
        {

        }
    }
}
