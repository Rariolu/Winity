using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TextFormats
{
    #region MainClassFileFormat
    public const string mainClassFileFormat = @"
using UnityEngine;
using System.Collections;

public partial class {0}
{{
    public {0}()
    {{
        InitialiseComponent();
    }}
}}
";

    #endregion

    #region DesignerClassFileFormat
    public const string designerClassFileFormat = @"
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

partial class {0}
{{
    #region GeneratedCode

    private void InitialiseComponent()
    {{
        if (EditorApplication.isPlaying)
        {{
            scene = SceneManager.CreateScene(""{0}"");
        }}
        else
        {{
            scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
            scene.name = ""{0}"";
        }}
        SceneManager.SetActiveScene(scene);

        unityObjectMap = new Dictionary<int, Object>();
        MapObjects();
      
{1}
    }}

    #endregion

    #region ObjectMapping

    void MapObjects()
    {{
{2}
    }}

    #endregion

    #region GameObjectFunctions

{3}
    #endregion

    #region Variables

    Scene scene;
    Dictionary<int,Object> unityObjectMap;
{4}
    #endregion
}}
";
    #endregion
}