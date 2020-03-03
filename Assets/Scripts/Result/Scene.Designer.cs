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
		GameObject main_camera = new GameObject();
		main_camera.name = "Main Camera";
		UnityEngine.Transform main_camera_transform_0 = main_camera.AddComponent<UnityEngine.Transform>();
		UnityEngine.Camera main_camera_camera_0 = main_camera.AddComponent<UnityEngine.Camera>();
		UnityEngine.AudioListener main_camera_audiolistener_0 = main_camera.AddComponent<UnityEngine.AudioListener>();
		return main_camera;
	}
	private GameObject directional_light_Init()
	{
		GameObject directional_light = new GameObject();
		directional_light.name = "Directional Light";
		UnityEngine.Transform directional_light_transform_0 = directional_light.AddComponent<UnityEngine.Transform>();
		UnityEngine.Light directional_light_light_0 = directional_light.AddComponent<UnityEngine.Light>();
		{
			GameObject deathtoameri_ca = new GameObject();
			deathtoameri_ca.name = "deathToAmeri ca";
			deathtoameri_ca.tag = "Untagged";
			deathtoameri_ca.transform.parent = directional_light.transform;
			UnityEngine.Transform deathtoameri_ca_transform_0 = deathtoameri_ca.AddComponent<UnityEngine.Transform>();
		}
		return directional_light;
	}
	private GameObject blep_Init()
	{
		GameObject blep = new GameObject();
		blep.name = "blep";
		UnityEngine.Transform blep_transform_0 = blep.AddComponent<UnityEngine.Transform>();
		{
			GameObject gameobject = new GameObject();
			gameobject.name = "GameObject";
			gameobject.tag = "Untagged";
			gameobject.transform.parent = blep.transform;
			UnityEngine.Transform gameobject_transform_0 = gameobject.AddComponent<UnityEngine.Transform>();
			GameObject gameobject__1 = new GameObject();
			gameobject__1.name = "GameObject (1)";
			gameobject__1.tag = "Untagged";
			gameobject__1.transform.parent = blep.transform;
			UnityEngine.Transform gameobject__1_transform_0 = gameobject__1.AddComponent<UnityEngine.Transform>();
		}
		return blep;
	}
	#endregion
	Scene scene;
	GameObject main_camera;
	GameObject directional_light;
	GameObject blep;
}
