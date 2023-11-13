using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSite
{
    public class TranningEntity
    {
        public const int DescriptionLength = 256;
        public System.Guid ID { get; set; }
        public string Description { get; set; }
        public TranningEntity(System.Guid id, string Description)
        {
            if (Description != null && Description.Length > DescriptionLength)
            {
                throw new ArgumentException($"Description exceeds {DescriptionLength} characters.");
            }
            this.ID = GenerateUniqueID();
            this.Description = Description;
        }
        public override string ToString()
        {
            return Description;
        }
        public Guid GenerateUniqueID()
        {
            return Guid.NewGuid();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TranningLesson))
            {
                return false;
            }
            TranningLesson other = (TranningLesson)obj;
            return ID.Equals(other.ID);
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
