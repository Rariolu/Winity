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
		main_camera.tag = "MainCamera";
		UnityEngine.Camera main_camera_camera_0 = main_camera.AddComponent<UnityEngine.Camera>();
		UnityEngine.AudioListener main_camera_audiolistener_0 = main_camera.AddComponent<UnityEngine.AudioListener>();
		return main_camera;
	}
	private GameObject directional_light_Init()
	{
		GameObject directional_light = new GameObject();
		directional_light.name = "Directional Light";
		directional_light.tag = "Untagged";
		UnityEngine.Light directional_light_light_0 = directional_light.AddComponent<UnityEngine.Light>();
		{
			GameObject deathtoameri_ca = new GameObject();
			deathtoameri_ca.name = "deathToAmeri ca";
			deathtoameri_ca.tag = "Untagged";
			deathtoameri_ca.transform.parent = directional_light.transform;
		}
		return directional_light;
	}
	private GameObject blep_Init()
	{
		GameObject blep = new GameObject();
		blep.name = "blep";
		blep.tag = "Untagged";
		{
			GameObject gameobject = new GameObject();
			gameobject.name = "GameObject";
			gameobject.tag = "Untagged";
			gameobject.transform.parent = blep.transform;
			NewBehaviourScript1 gameobject_newbehaviourscript1_0 = gameobject.AddComponent<NewBehaviourScript1>();
			GameObject gameobject__1 = new GameObject();
			gameobject__1.name = "GameObject (1)";
			gameobject__1.tag = "Untagged";
			gameobject__1.transform.parent = blep.transform;
			{
				GameObject audio_source = new GameObject();
				audio_source.name = "Audio Source";
				audio_source.tag = "Untagged";
				audio_source.transform.parent = gameobject__1.transform;
				UnityEngine.AudioSource audio_source_audiosource_0 = audio_source.AddComponent<UnityEngine.AudioSource>();
			}
		}
		return blep;
	}
	#endregion
	Scene scene;
	GameObject main_camera;
	GameObject directional_light;
	GameObject blep;
}
