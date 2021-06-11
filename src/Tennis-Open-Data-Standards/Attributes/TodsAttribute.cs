using System;

namespace Tennis_Open_Data_Standards.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class TodsAttribute : Attribute
    {
        public string Version { get; set; }
    }
}
