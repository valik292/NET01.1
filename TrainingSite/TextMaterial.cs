using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSite
{
    class TextMaterial : TranningMaterial
    {
        public const int TextLength = 1000;
        public string Text { get; set; }
        public TextMaterial(Guid id, string Description, string text) : base(id, Description)
        {
            if (text == null || text.Length > TextLength)
            {
                throw new ArgumentException($"The text exceeds {TextLength} characters or is empty.");
            }
            this.ID = id;
            this.Description = Description;
            this.Text = text;
            this.Description = Description;
        }
    }
}
