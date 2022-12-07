using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TextFormats
{
    #region Scene

    #region MainClassFileFormat
    public const string mainSceneClassFileFormat = 
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
    public const string designerSceneClassFileFormat = 
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

    #endregion

    #region Prefab

    #region PrefabMainClass

    public const string mainPrefabClassFileFormat =
@"using UnityEngine;
using System.Collections;
using WinformsUnity;

public partial class {0} : Prefab
{{
    public {0}() : base(""{1}"")
    {{

    }} 
}}
";

    #endregion

    public const string designerPrefabClassFileFormat =
@"using UnityEngine;
using System.Collections;
using WinformsUnity;

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