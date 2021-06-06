using System;

namespace SVService.App_Data
{
    public class TableNameAttr : Attribute
    {
        public string Name { get; set; }
        public TableNameAttr(string _Name)
        {
            this.Name = _Name;
        }
    }
}