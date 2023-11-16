using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    // Çıplak Class Kalmasın!!!!
    /* Eğer ki bir class herhangi bir inheritance veya interface 
       implementasyonu almıyorsa ilerde sıkıntı yaşarsın bu yüzden 
       onları işaretle/gruplama eğilimine gireriz.                  */
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
