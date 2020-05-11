using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

partial class NewScene
{
    #region ObjectMapping

    protected override void MapObjects()
    {
		//Main Camera
		GameObject gameObject12566 = new GameObject();
		SetObject(12566, gameObject12566);
		Transform transform12572 = gameObject12566.transform;
		SetObject(12572,transform12572);
		UnityEngine.Camera component12570 = gameObject12566.AddComponent<UnityEngine.Camera>();
		SetObject(12570,component12570);
		UnityEngine.AudioListener component12568 = gameObject12566.AddComponent<UnityEngine.AudioListener>();
		SetObject(12568,component12568);
		
		//Directional Light
		GameObject gameObject12560 = new GameObject();
		SetObject(12560, gameObject12560);
		Transform transform12564 = gameObject12560.transform;
		SetObject(12564,transform12564);
		UnityEngine.Light component12562 = gameObject12560.AddComponent<UnityEngine.Light>();
		SetObject(12562,component12562);
		
		//deathToAmeri ca
		GameObject gameObject12556 = new GameObject();
		SetObject(12556, gameObject12556);
		Transform transform12558 = gameObject12556.transform;
		SetObject(12558,transform12558);
		
		//blep
		GameObject gameObject12536 = new GameObject();
		SetObject(12536, gameObject12536);
		Transform transform12538 = gameObject12536.transform;
		SetObject(12538,transform12538);
		
		//GameObject
		GameObject gameObject12540 = new GameObject();
		SetObject(12540, gameObject12540);
		Transform transform12542 = gameObject12540.transform;
		SetObject(12542,transform12542);
		NewBehaviourScript1 component12544 = gameObject12540.AddComponent<NewBehaviourScript1>();
		SetObject(12544,component12544);
		
		//GameObject (1)
		GameObject gameObject12552 = new GameObject();
		SetObject(12552, gameObject12552);
		Transform transform12554 = gameObject12552.transform;
		SetObject(12554,transform12554);
		
		//Audio Source
		GameObject gameObject12546 = new GameObject();
		SetObject(12546, gameObject12546);
		Transform transform12548 = gameObject12546.transform;
		SetObject(12548,transform12548);
		UnityEngine.AudioSource component12550 = gameObject12546.AddComponent<UnityEngine.AudioSource>();
		SetObject(12550,component12550);
		
		//DefaultMcGee
		GameObject gameObject_6870 = new GameObject();
		SetObject(-6870, gameObject_6870);
		Transform transform_6872 = gameObject_6870.transform;
		SetObject(-6872,transform_6872);
		

    }

    #endregion

    #region GameObjectFunctions
    protected override void InitialiseGameObjects()
    {
		mainCamera = mainCamera_Init();
		directionalLight = directionalLight_Init();
		blep = blep_Init();
		defaultmcgee = defaultmcgee_Init();

    }

	private GameObject mainCamera_Init()
	{
		GameObject gomainCamera_12566 = (GetObject(12566) as GameObject);
		gomainCamera_12566.name = "Main Camera";
		gomainCamera_12566.tag = "MainCamera";
		UnityEngine.Transform commainCamera_transform_0_12572 = (GetObject(12572) as UnityEngine.Transform);
		commainCamera_transform_0_12572.position = new Vector3(0f,1f,-10f);
		commainCamera_transform_0_12572.localPosition = new Vector3(0f,1f,-10f);
		commainCamera_transform_0_12572.tag = "MainCamera";
		UnityEngine.Camera commainCamera_camera_0_12570 = (GetObject(12570) as UnityEngine.Camera);
		commainCamera_camera_0_12570.depth = -1f;
		commainCamera_camera_0_12570.layerCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		commainCamera_camera_0_12570.cullingMatrix = new Matrix4x4(new Vector4(0.9761558f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,1.0006f,1f),new Vector4(0f,-1.732051f,9.405821f,10f));
		commainCamera_camera_0_12570.worldToCameraMatrix = new Matrix4x4(new Vector4(1f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4(0f,0f,-1f,0f),new Vector4(0f,-1f,-10f,1f));
		commainCamera_camera_0_12570.tag = "MainCamera";
		UnityEngine.AudioListener commainCamera_audiolistener_0_12568 = (GetObject(12568) as UnityEngine.AudioListener);
		commainCamera_audiolistener_0_12568.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Dynamic;
		commainCamera_audiolistener_0_12568.tag = "MainCamera";
		return gomainCamera_12566;
	}
	private GameObject directionalLight_Init()
	{
		GameObject godirectionalLight_12560 = (GetObject(12560) as GameObject);
		godirectionalLight_12560.name = "Directional Light";
		godirectionalLight_12560.tag = "Untagged";
		UnityEngine.Transform comdirectionalLight_transform_0_12564 = (GetObject(12564) as UnityEngine.Transform);
		comdirectionalLight_transform_0_12564.position = new Vector3(0f,3f,0f);
		comdirectionalLight_transform_0_12564.localPosition = new Vector3(0f,3f,0f);
		comdirectionalLight_transform_0_12564.eulerAngles = new Vector3(50f,330f,0f);
		comdirectionalLight_transform_0_12564.localEulerAngles = new Vector3(50f,330f,0f);
		comdirectionalLight_transform_0_12564.right = new Vector3(0.8660254f,0f,0.4999999f);
		comdirectionalLight_transform_0_12564.up = new Vector3(-0.3830222f,0.6427876f,0.6634139f);
		comdirectionalLight_transform_0_12564.forward = new Vector3(-0.3213938f,-0.7660444f,0.5566705f);
		comdirectionalLight_transform_0_12564.rotation = new Quaternion(0.4082179f,-0.2345697f,0.1093816f,0.8754261f);
		comdirectionalLight_transform_0_12564.localRotation = new Quaternion(0.4082179f,-0.2345697f,0.1093816f,0.8754261f);
		comdirectionalLight_transform_0_12564.hierarchyCapacity = 2;
		UnityEngine.Light comdirectionalLight_light_0_12562 = (GetObject(12562) as UnityEngine.Light);
		comdirectionalLight_light_0_12562.type = UnityEngine.LightType.Directional;
		comdirectionalLight_light_0_12562.color = new Color(1f,0.9568627f,0.8392157f,1f);
		comdirectionalLight_light_0_12562.shadows = UnityEngine.LightShadows.Soft;
		comdirectionalLight_light_0_12562.layerShadowCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		{
			GameObject godeathtoameriCa_12556 = (GetObject(12556) as GameObject);
			godeathtoameriCa_12556.name = "deathToAmeri ca";
			godeathtoameriCa_12556.tag = "Untagged";
			UnityEngine.Transform comdeathtoameriCa_transform_0_12558 = (GetObject(12558) as UnityEngine.Transform);
			comdeathtoameriCa_transform_0_12558.position = new Vector3(0f,3f,0f);
			comdeathtoameriCa_transform_0_12558.eulerAngles = new Vector3(50f,330f,0f);
			comdeathtoameriCa_transform_0_12558.right = new Vector3(0.8660254f,0f,0.4999999f);
			comdeathtoameriCa_transform_0_12558.up = new Vector3(-0.3830222f,0.6427876f,0.6634139f);
			comdeathtoameriCa_transform_0_12558.forward = new Vector3(-0.3213938f,-0.7660444f,0.5566705f);
			comdeathtoameriCa_transform_0_12558.rotation = new Quaternion(0.4082179f,-0.2345697f,0.1093816f,0.8754261f);
			comdeathtoameriCa_transform_0_12558.parent = (GetObject(12564) as UnityEngine.Transform);
			comdeathtoameriCa_transform_0_12558.hierarchyCapacity = 2;
		}
		return godirectionalLight_12560;
	}
	private GameObject blep_Init()
	{
		GameObject goblep_12536 = (GetObject(12536) as GameObject);
		goblep_12536.name = "blep";
		goblep_12536.tag = "Untagged";
		UnityEngine.Transform comblep_transform_0_12538 = (GetObject(12538) as UnityEngine.Transform);
		comblep_transform_0_12538.hierarchyCapacity = 4;
		{
			GameObject gogameobject_12540 = (GetObject(12540) as GameObject);
			gogameobject_12540.name = "GameObject";
			gogameobject_12540.tag = "Untagged";
			UnityEngine.Transform comgameobject_transform_0_12542 = (GetObject(12542) as UnityEngine.Transform);
			comgameobject_transform_0_12542.parent = (GetObject(12538) as UnityEngine.Transform);
			comgameobject_transform_0_12542.hierarchyCapacity = 4;
			NewBehaviourScript1 comgameobject_newbehaviourscript1_0_12544 = (GetObject(12544) as NewBehaviourScript1);
			comgameobject_newbehaviourscript1_0_12544.rir = new System.Int32[] { 3, 76, 42 };
			comgameobject_newbehaviourscript1_0_12544.testObj = (GetObject(12566) as UnityEngine.GameObject);
			comgameobject_newbehaviourscript1_0_12544.tempStruct = default(TempStruct);
			comgameobject_newbehaviourscript1_0_12544.tempClass = default(TempClass);
			comgameobject_newbehaviourscript1_0_12544.testObj2 = default(UnityEngine.GameObject);
			GameObject gogameobject_1__12552 = (GetObject(12552) as GameObject);
			gogameobject_1__12552.name = "GameObject (1)";
			gogameobject_1__12552.tag = "Untagged";
			UnityEngine.Transform comgameobject_1__transform_0_12554 = (GetObject(12554) as UnityEngine.Transform);
			comgameobject_1__transform_0_12554.parent = (GetObject(12538) as UnityEngine.Transform);
			comgameobject_1__transform_0_12554.hierarchyCapacity = 4;
			{
				GameObject goaudioSource_12546 = (GetObject(12546) as GameObject);
				goaudioSource_12546.name = "Audio Source";
				goaudioSource_12546.tag = "Untagged";
				UnityEngine.Transform comaudioSource_transform_0_12548 = (GetObject(12548) as UnityEngine.Transform);
				comaudioSource_transform_0_12548.parent = (GetObject(12554) as UnityEngine.Transform);
				comaudioSource_transform_0_12548.hierarchyCapacity = 4;
				UnityEngine.AudioSource comaudioSource_audiosource_0_12550 = (GetObject(12550) as UnityEngine.AudioSource);
			}
		}
		return goblep_12536;
	}
	private GameObject defaultmcgee_Init()
	{
		GameObject godefaultmcgee__6870 = (GetObject(-6870) as GameObject);
		godefaultmcgee__6870.name = "DefaultMcGee";
		godefaultmcgee__6870.tag = "Untagged";
		UnityEngine.Transform comdefaultmcgee_transform_0__6872 = (GetObject(-6872) as UnityEngine.Transform);
		return godefaultmcgee__6870;
	}

    #endregion

    #region Variables

	GameObject mainCamera;
	GameObject directionalLight;
	GameObject blep;
	GameObject defaultmcgee;

    #endregion
}
