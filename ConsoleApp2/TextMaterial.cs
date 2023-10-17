using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{  
    class TextMaterial : TranningMaterial
    {
        public const int textLength = 1000;
        public string Text { get; set; }
        public TextMaterial(Guid id, string Description, string text) : base(id, Description)
        {
            if (text == null || text.Length > textLength)
            {
                throw new ArgumentException($"Текст превышает {textLength} символов или он пустой.");
            }
            this.ID = id;
            this.description = Description;
            this.Text = text;
            this.description = Description;
        }
    }
}
