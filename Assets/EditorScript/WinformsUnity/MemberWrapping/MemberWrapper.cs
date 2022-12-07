using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public abstract class MemberWrapper
{
    MemberInfo memberInfo;

    static string[] ignoredMembers = new string[]
    {
        "gameObject",
        "transform",
        "name"
    };

    public MemberWrapper(MemberInfo _memberInfo)
    {
        memberInfo = _memberInfo;
    }

    public static MemberWrapper GenerateWrapper(MemberInfo memberInfo)
    {
        if (memberInfo != null)
        {
            switch (memberInfo.MemberType)
            {
                case MemberTypes.Property:
                {
                    return new PropertyWrapper((PropertyInfo)memberInfo);
                }
                case MemberTypes.Field:
                {
                    return new FieldWrapper((FieldInfo)memberInfo);
                }
            }
        }
        return null;
    }

    public bool IsObsolete
    {
        get
        {
            return memberInfo.GetCustomAttributes(typeof(ObsoleteAttribute)).Count() > 0;
        }
    }

    public bool HasIgnoredName
    {
        get
        {
            return ignoredMembers.Contains(memberInfo.Name);
        }
    }

    public abstract Type TypeOfMember
    {
        get;
    }
    public abstract object GetValue(object obj);
    public abstract bool HasStaticAccessor
    {
        get;
    }
    public abstract MemberInfo MemberInfo
    {
        get;
    }
    public abstract bool CanWrite
    {
        get;
    }
}