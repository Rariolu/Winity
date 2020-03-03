using UnityEngine.SceneManagement;
partial class new_scene
{
	#region GeneratedCode
	private void InitialiseComponent()
	{
		scene = new Scene();
		SceneManager.SetActiveScene(scene);
		scene.name = "New Scene";
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
