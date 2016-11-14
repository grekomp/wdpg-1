using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuClasses
{
    public abstract class MenuItem
    {
        public string Label { get; protected set; }
        public string GenerateLabel()
        {
            return Label;
        }

        public string Description { get; protected set; }
        public string GenerateDescription()
        {
            return Description;
        }

        public virtual Boolean Start()
        {
            Message = "This is the default menu item method, please overwrite it in your class";

            return true;
        }

        public string Message { get; protected set; }
        public string GetMessage()
        {
            return Message;
        }

        public MenuItem()
        {
            Label = "(!) No label set (!)";
            Description = "(i) No description";
        }

        public MenuItem(string label)
        {
            Label = label;
        }

        public MenuItem(string label, string description)
        {
            Label = label;
            Description = description;
        }
    }
}
