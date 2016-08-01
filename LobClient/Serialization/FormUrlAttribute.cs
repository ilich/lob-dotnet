using System;

namespace Lob.Serialization
{
    [AttributeUsage(AttributeTargets.Property)]
    class FormUrlAttribute : Attribute
    {
        public FormUrlAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
