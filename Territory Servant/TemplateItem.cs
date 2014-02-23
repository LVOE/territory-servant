using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Territory_Servant
{
    class TemplateItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public TemplateItem(String Text, String Value) {
            this.Text = Text;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
