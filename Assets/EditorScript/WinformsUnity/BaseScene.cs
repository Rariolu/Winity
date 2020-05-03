using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
using UObject = UnityEngine.Object;

namespace WinformsUnity
{
    public abstract class BaseScene
    {
        public BaseScene()
        {
#if UNITY_EDITOR
            if (EditorApplication.isPlaying)
            {
                scene = SceneManager.CreateScene("newScene");

                SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            }
            else
            {
                scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
                scene.name = "newScene";
            }
#else
            scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
            scene.name = "newScene";
#endif
            SceneManager.SetActiveScene(scene);
            unityObjectMap = new Dictionary<int, UObject>();
            MapObjects();
        }

        protected abstract void MapObjects();

        Scene scene;
        protected Dictionary<int, UObject> unityObjectMap;
    }
}