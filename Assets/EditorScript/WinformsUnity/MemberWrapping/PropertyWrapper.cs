using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class PropertyWrapper : MemberWrapper
{
    PropertyInfo propertyInfo;

    public PropertyWrapper(PropertyInfo _propertyInfo) : base(_propertyInfo)
    {
        propertyInfo = _propertyInfo;
    }

    public override Type TypeOfMember
    {
        get
        {
            return propertyInfo.PropertyType;
        }
    }

    public override object GetValue(object obj)
    {
        return propertyInfo.GetValue(obj);
    }

    public override bool HasStaticAccessor
    {
        get
        {
            return propertyInfo.GetAccessors().Any(x => x.IsStatic);
        }
    }

    public override MemberInfo MemberInfo
    {
        get
        {
            return propertyInfo;
        }
    }

    public override bool CanWrite
    {
        get
        {
            return propertyInfo.CanWrite;
        }
    }
}