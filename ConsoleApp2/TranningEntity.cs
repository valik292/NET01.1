using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class TranningEntity
    {
        public const int DescriptionLength = 256;
        public System.Guid ID { get; set; }
        public string description { get; set; }
        public TranningEntity(System.Guid id, string Description)
        {
            if (Description != null && Description.Length > DescriptionLength)
            {
                throw new ArgumentException($"Описание превышает {DescriptionLength} символов.");
            }           
            this.ID = id;
            this.description = Description; 
        }
        public override string ToString()
        {
            return description;
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
