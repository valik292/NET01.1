using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSite
{
    public class TranningMaterial : TranningEntity
    {
        public TranningMaterial(Guid id, string Description) : base(id, Description)
        {
            this.ID = id;
            this.Description = Description;

        }
    }
}
