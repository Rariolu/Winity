using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

partial class NewScene1
{
    #region ObjectMapping

    protected override void MapObjects()
    {
		//Main Camera
		GameObject gameObject12310 = new GameObject();
		SetObject(12310, gameObject12310);
		Transform transform12316 = gameObject12310.transform;
		SetObject(12316,transform12316);
		UnityEngine.Camera component12314 = gameObject12310.AddComponent<UnityEngine.Camera>();
		SetObject(12314,component12314);
		UnityEngine.AudioListener component12312 = gameObject12310.AddComponent<UnityEngine.AudioListener>();
		SetObject(12312,component12312);
		
		//Directional Light
		GameObject gameObject12318 = new GameObject();
		SetObject(12318, gameObject12318);
		Transform transform12322 = gameObject12318.transform;
		SetObject(12322,transform12322);
		UnityEngine.Light component12320 = gameObject12318.AddComponent<UnityEngine.Light>();
		SetObject(12320,component12320);
		
		//bbgbfbdb
		GameObject gameObject_2144 = new GameObject();
		SetObject(-2144, gameObject_2144);
		Transform transform_2146 = gameObject_2144.transform;
		SetObject(-2146,transform_2146);
		NewBehaviourScript1 component_2224 = gameObject_2144.AddComponent<NewBehaviourScript1>();
		SetObject(-2224,component_2224);
		

    }

    #endregion

    #region GameObjectFunctions
    protected override void InitialiseGameObjects()
    {
		mainCamera = mainCamera_Init();
		directionalLight = directionalLight_Init();
		bbgbfbdb = bbgbfbdb_Init();

    }

	private GameObject mainCamera_Init()
	{
		GameObject gomainCamera_12310 = (GetObject(12310) as GameObject);
		gomainCamera_12310.name = "Main Camera";
		gomainCamera_12310.tag = "MainCamera";
		UnityEngine.Transform commainCamera_transform_0_12316 = (GetObject(12316) as UnityEngine.Transform);
		commainCamera_transform_0_12316.position = new Vector3(0f,1f,-10f);
		commainCamera_transform_0_12316.localPosition = new Vector3(0f,1f,-10f);
		commainCamera_transform_0_12316.eulerAngles = new Vector3(0f,0f,0f);
		commainCamera_transform_0_12316.localEulerAngles = new Vector3(0f,0f,0f);
		commainCamera_transform_0_12316.right = new Vector3(1f,0f,0f);
		commainCamera_transform_0_12316.up = new Vector3(0f,1f,0f);
		commainCamera_transform_0_12316.forward = new Vector3(0f,0f,1f);
		commainCamera_transform_0_12316.rotation = new Quaternion(0f,0f,0f,1f);
		commainCamera_transform_0_12316.localRotation = new Quaternion(0f,0f,0f,1f);
		commainCamera_transform_0_12316.localScale = new Vector3(1f,1f,1f);
		commainCamera_transform_0_12316.parent = null;
		commainCamera_transform_0_12316.hasChanged = true;
		commainCamera_transform_0_12316.hierarchyCapacity = 1;
		commainCamera_transform_0_12316.tag = "MainCamera";
		commainCamera_transform_0_12316.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.Camera commainCamera_camera_0_12314 = (GetObject(12314) as UnityEngine.Camera);
		commainCamera_camera_0_12314.nearClipPlane = 0.3f;
		commainCamera_camera_0_12314.farClipPlane = 1000f;
		commainCamera_camera_0_12314.fieldOfView = 60f;
		commainCamera_camera_0_12314.renderingPath = UnityEngine.RenderingPath.UsePlayerSettings;
		commainCamera_camera_0_12314.allowHDR = true;
		commainCamera_camera_0_12314.allowMSAA = true;
		commainCamera_camera_0_12314.allowDynamicResolution = false;
		commainCamera_camera_0_12314.forceIntoRenderTexture = false;
		commainCamera_camera_0_12314.orthographicSize = 5f;
		commainCamera_camera_0_12314.orthographic = false;
		commainCamera_camera_0_12314.opaqueSortMode = UnityEngine.Rendering.OpaqueSortMode.Default;
		commainCamera_camera_0_12314.transparencySortMode = UnityEngine.TransparencySortMode.Default;
		commainCamera_camera_0_12314.transparencySortAxis = new Vector3(0f,0f,1f);
		commainCamera_camera_0_12314.depth = -1f;
		commainCamera_camera_0_12314.aspect = 1.774194f;
		commainCamera_camera_0_12314.cullingMask = -1;
		commainCamera_camera_0_12314.eventMask = -1;
		commainCamera_camera_0_12314.layerCullSpherical = false;
		commainCamera_camera_0_12314.cameraType = UnityEngine.CameraType.Game;
		commainCamera_camera_0_12314.overrideSceneCullingMask = 0;
		commainCamera_camera_0_12314.layerCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		commainCamera_camera_0_12314.useOcclusionCulling = true;
		commainCamera_camera_0_12314.cullingMatrix = new Matrix4x4(new Vector4(0.9762468f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,1.0006f,1f),new Vector4(0f,-1.732051f,9.405821f,10f));
		commainCamera_camera_0_12314.backgroundColor = new Color(0.1921569f,0.3019608f,0.4745098f,0f);
		commainCamera_camera_0_12314.clearFlags = UnityEngine.CameraClearFlags.Skybox;
		commainCamera_camera_0_12314.depthTextureMode = UnityEngine.DepthTextureMode.None;
		commainCamera_camera_0_12314.clearStencilAfterLightingPass = false;
		commainCamera_camera_0_12314.usePhysicalProperties = false;
		commainCamera_camera_0_12314.sensorSize = new Vector2(36f,24f);
		commainCamera_camera_0_12314.lensShift = new Vector2(0f,0f);
		commainCamera_camera_0_12314.focalLength = 50f;
		commainCamera_camera_0_12314.gateFit = UnityEngine.Camera.GateFitMode.Horizontal;
		commainCamera_camera_0_12314.rect = new Rect(0f,0f,1f,1f);
		commainCamera_camera_0_12314.pixelRect = new Rect(0f,0f,330f,186f);
		commainCamera_camera_0_12314.targetTexture = null;
		commainCamera_camera_0_12314.targetDisplay = 0;
		commainCamera_camera_0_12314.worldToCameraMatrix = new Matrix4x4(new Vector4(1f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4(0f,0f,-1f,0f),new Vector4(0f,-1f,-10f,1f));
		commainCamera_camera_0_12314.projectionMatrix = new Matrix4x4(new Vector4(0.9762468f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,-1.0006f,-1f),new Vector4(0f,0f,-0.60018f,0f));
		commainCamera_camera_0_12314.nonJitteredProjectionMatrix = new Matrix4x4(new Vector4(0.9762468f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,-1.0006f,-1f),new Vector4(0f,0f,-0.60018f,0f));
		commainCamera_camera_0_12314.useJitteredProjectionMatrixForTransparentRendering = true;
		commainCamera_camera_0_12314.scene = GetScene();
		commainCamera_camera_0_12314.stereoSeparation = 0.022f;
		commainCamera_camera_0_12314.stereoConvergence = 10f;
		commainCamera_camera_0_12314.stereoTargetEye = UnityEngine.StereoTargetEyeMask.Both;
		commainCamera_camera_0_12314.enabled = true;
		commainCamera_camera_0_12314.tag = "MainCamera";
		commainCamera_camera_0_12314.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.AudioListener commainCamera_audiolistener_0_12312 = (GetObject(12312) as UnityEngine.AudioListener);
		commainCamera_audiolistener_0_12312.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Dynamic;
		commainCamera_audiolistener_0_12312.enabled = true;
		commainCamera_audiolistener_0_12312.tag = "MainCamera";
		commainCamera_audiolistener_0_12312.hideFlags = UnityEngine.HideFlags.None;
		return gomainCamera_12310;
	}
	private GameObject directionalLight_Init()
	{
		GameObject godirectionalLight_12318 = (GetObject(12318) as GameObject);
		godirectionalLight_12318.name = "Directional Light";
		godirectionalLight_12318.tag = "Untagged";
		UnityEngine.Transform comdirectionalLight_transform_0_12322 = (GetObject(12322) as UnityEngine.Transform);
		comdirectionalLight_transform_0_12322.position = new Vector3(0f,3f,0f);
		comdirectionalLight_transform_0_12322.localPosition = new Vector3(0f,3f,0f);
		comdirectionalLight_transform_0_12322.eulerAngles = new Vector3(50f,330f,0f);
		comdirectionalLight_transform_0_12322.localEulerAngles = new Vector3(50f,330f,0f);
		comdirectionalLight_transform_0_12322.right = new Vector3(0.8660254f,0f,0.4999999f);
		comdirectionalLight_transform_0_12322.up = new Vector3(-0.3830222f,0.6427876f,0.6634139f);
		comdirectionalLight_transform_0_12322.forward = new Vector3(-0.3213938f,-0.7660444f,0.5566705f);
		comdirectionalLight_transform_0_12322.rotation = new Quaternion(0.4082179f,-0.2345697f,0.1093816f,0.8754261f);
		comdirectionalLight_transform_0_12322.localRotation = new Quaternion(0.4082179f,-0.2345697f,0.1093816f,0.8754261f);
		comdirectionalLight_transform_0_12322.localScale = new Vector3(1f,1f,1f);
		comdirectionalLight_transform_0_12322.parent = null;
		comdirectionalLight_transform_0_12322.hasChanged = true;
		comdirectionalLight_transform_0_12322.hierarchyCapacity = 1;
		comdirectionalLight_transform_0_12322.tag = "Untagged";
		comdirectionalLight_transform_0_12322.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.Light comdirectionalLight_light_0_12320 = (GetObject(12320) as UnityEngine.Light);
		comdirectionalLight_light_0_12320.type = UnityEngine.LightType.Directional;
		comdirectionalLight_light_0_12320.spotAngle = 30f;
		comdirectionalLight_light_0_12320.innerSpotAngle = 21.80208f;
		comdirectionalLight_light_0_12320.color = new Color(1f,0.9568627f,0.8392157f,1f);
		comdirectionalLight_light_0_12320.colorTemperature = 6570f;
		comdirectionalLight_light_0_12320.intensity = 1f;
		comdirectionalLight_light_0_12320.bounceIntensity = 1f;
		comdirectionalLight_light_0_12320.useBoundingSphereOverride = false;
		comdirectionalLight_light_0_12320.boundingSphereOverride = new Vector4(0f,0f,0f,0f);
		comdirectionalLight_light_0_12320.shadowCustomResolution = -1;
		comdirectionalLight_light_0_12320.shadowBias = 0.05f;
		comdirectionalLight_light_0_12320.shadowNormalBias = 0.4f;
		comdirectionalLight_light_0_12320.shadowNearPlane = 0.2f;
		comdirectionalLight_light_0_12320.useShadowMatrixOverride = false;
		comdirectionalLight_light_0_12320.shadowMatrixOverride = new Matrix4x4(new Vector4(1f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4(0f,0f,1f,0f),new Vector4(0f,0f,0f,1f));
		comdirectionalLight_light_0_12320.range = 10f;
		comdirectionalLight_light_0_12320.flare = null;
		comdirectionalLight_light_0_12320.bakingOutput = default(UnityEngine.LightBakingOutput);
		comdirectionalLight_light_0_12320.cullingMask = -1;
		comdirectionalLight_light_0_12320.renderingLayerMask = 1;
		comdirectionalLight_light_0_12320.lightShadowCasterMode = UnityEngine.LightShadowCasterMode.Default;
		comdirectionalLight_light_0_12320.shadowRadius = 0f;
		comdirectionalLight_light_0_12320.shadowAngle = 0f;
		comdirectionalLight_light_0_12320.shadows = UnityEngine.LightShadows.Soft;
		comdirectionalLight_light_0_12320.shadowStrength = 1f;
		comdirectionalLight_light_0_12320.shadowResolution = UnityEngine.Rendering.LightShadowResolution.FromQualitySettings;
		comdirectionalLight_light_0_12320.layerShadowCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		comdirectionalLight_light_0_12320.cookieSize = 10f;
		comdirectionalLight_light_0_12320.cookie = null;
		comdirectionalLight_light_0_12320.renderMode = UnityEngine.LightRenderMode.Auto;
		comdirectionalLight_light_0_12320.areaSize = new Vector2(1f,1f);
		comdirectionalLight_light_0_12320.lightmapBakeType = UnityEngine.LightmapBakeType.Realtime;
		comdirectionalLight_light_0_12320.enabled = true;
		comdirectionalLight_light_0_12320.tag = "Untagged";
		comdirectionalLight_light_0_12320.hideFlags = UnityEngine.HideFlags.None;
		return godirectionalLight_12318;
	}
	private GameObject bbgbfbdb_Init()
	{
		GameObject gobbgbfbdb__2144 = (GetObject(-2144) as GameObject);
		gobbgbfbdb__2144.name = "bbgbfbdb";
		gobbgbfbdb__2144.tag = "Untagged";
		UnityEngine.Transform combbgbfbdb_transform_0__2146 = (GetObject(-2146) as UnityEngine.Transform);
		combbgbfbdb_transform_0__2146.position = new Vector3(0f,0f,0f);
		combbgbfbdb_transform_0__2146.localPosition = new Vector3(0f,0f,0f);
		combbgbfbdb_transform_0__2146.eulerAngles = new Vector3(0f,0f,0f);
		combbgbfbdb_transform_0__2146.localEulerAngles = new Vector3(0f,0f,0f);
		combbgbfbdb_transform_0__2146.right = new Vector3(1f,0f,0f);
		combbgbfbdb_transform_0__2146.up = new Vector3(0f,1f,0f);
		combbgbfbdb_transform_0__2146.forward = new Vector3(0f,0f,1f);
		combbgbfbdb_transform_0__2146.rotation = new Quaternion(0f,0f,0f,1f);
		combbgbfbdb_transform_0__2146.localRotation = new Quaternion(0f,0f,0f,1f);
		combbgbfbdb_transform_0__2146.localScale = new Vector3(1f,1f,1f);
		combbgbfbdb_transform_0__2146.parent = null;
		combbgbfbdb_transform_0__2146.hasChanged = true;
		combbgbfbdb_transform_0__2146.hierarchyCapacity = 1;
		combbgbfbdb_transform_0__2146.tag = "Untagged";
		combbgbfbdb_transform_0__2146.hideFlags = UnityEngine.HideFlags.None;
		NewBehaviourScript1 combbgbfbdb_newbehaviourscript1_0__2224 = (GetObject(-2224) as NewBehaviourScript1);
		combbgbfbdb_newbehaviourscript1_0__2224.useGUILayout = true;
		combbgbfbdb_newbehaviourscript1_0__2224.runInEditMode = false;
		combbgbfbdb_newbehaviourscript1_0__2224.enabled = true;
		combbgbfbdb_newbehaviourscript1_0__2224.tag = "Untagged";
		combbgbfbdb_newbehaviourscript1_0__2224.hideFlags = UnityEngine.HideFlags.None;
		combbgbfbdb_newbehaviourscript1_0__2224.die = "dsadsasd";
		combbgbfbdb_newbehaviourscript1_0__2224.rir = new System.Int32[] {  };
		combbgbfbdb_newbehaviourscript1_0__2224.testObj = (GetObject(0) as UnityEngine.GameObject);
		combbgbfbdb_newbehaviourscript1_0__2224.tempStruct = default(TempStruct);
		combbgbfbdb_newbehaviourscript1_0__2224.tempClass = default(TempClass);
		return gobbgbfbdb__2144;
	}

    #endregion

    #region Variables

	GameObject mainCamera;
	GameObject directionalLight;
	GameObject bbgbfbdb;

    #endregion
}
