using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TextFormats
{
    #region MainClassFileFormat
    public const string mainClassFileFormat = 
@"using UnityEngine;
using System.Collections;
using WinformsUnity;

public partial class {0} : BaseScene
{{
    public {0}() : base(""{1}"")
    {{
        
    }}
}}
";

    #endregion

    #region DesignerClassFileFormat
    public const string designerClassFileFormat = 
@"using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

partial class {0}
{{
    #region ObjectMapping

    protected override void MapObjects()
    {{
{1}
    }}

    #endregion

    #region GameObjectFunctions
    protected override void InitialiseGameObjects()
    {{
{2}
    }}

{3}
    #endregion

    #region Variables

{4}
    #endregion
}}
";
    #endregion
}