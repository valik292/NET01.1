using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class TranningMaterial : TranningEntity
    {
        public TranningMaterial(Guid id, string Description) : base(id, Description)
        {      
            this.ID = id;
            this.description = Description;
           
        }
    }
}
