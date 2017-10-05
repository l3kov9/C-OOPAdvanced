using System;

namespace AttributesDemo
{
    [Author("Gosho")]
    [Flags]
    public enum Permission
    {
        Read=1,
        Write=2,
        ReadWrite=Read | Write
    }
}
