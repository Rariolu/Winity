using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class FieldWrapper : MemberWrapper
{
    FieldInfo fieldInfo;

    public FieldWrapper(FieldInfo _fieldInfo) : base (_fieldInfo)
    {
        fieldInfo = _fieldInfo;
    }

    public override Type TypeOfMember
    {
        get
        {
            return fieldInfo.FieldType;
        }
    }

    public override object GetValue(object obj)
    {
        return fieldInfo.GetValue(obj);
    }

    public override bool HasStaticAccessor
    {
        get
        {
            return fieldInfo.IsStatic;
        }
    }

    public override MemberInfo MemberInfo
    {
        get
        {
            return fieldInfo;
        }
    }

    public override bool CanWrite
    {
        get
        {
            return fieldInfo.IsInitOnly;
        }
    }
}