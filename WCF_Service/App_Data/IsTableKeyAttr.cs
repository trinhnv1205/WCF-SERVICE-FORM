using System;

namespace SVService.App_Data
{
    public class IsTableKeyAttr : Attribute
    {
        public bool AutoIncrement { get; set; }
        
        public IsTableKeyAttr(bool _AutoIncrement)
        {
            this.AutoIncrement = _AutoIncrement;
        }
    }
}