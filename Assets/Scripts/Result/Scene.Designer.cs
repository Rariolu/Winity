using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
partial class phoenix
{
	#region GeneratedCode
	private void InitialiseComponent()
	{
		if (EditorApplication.isPlaying)
		{
			scene = SceneManager.CreateScene("Phoenix");
		}
		else
		{
			scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
			scene.name = "Phoenix";
		}
		SceneManager.SetActiveScene(scene);
		main_camera = main_camera_Init();
		directional_light = directional_light_Init();
		blep = blep_Init();
	}
	private GameObject main_camera_Init()
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Main Camera";
		return gameObject;
	}
	private GameObject directional_light_Init()
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Directional Light";
		return gameObject;
	}
	private GameObject blep_Init()
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "blep";
		return gameObject;
	}
	#endregion
	Scene scene;
	GameObject main_camera;
	GameObject directional_light;
	GameObject blep;
}
