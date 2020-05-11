using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

partial class Other
{
    #region ObjectMapping

    protected override void MapObjects()
    {
		//Main Camera
		GameObject gameObject12228 = new GameObject();
		SetObject(12228, gameObject12228);
		Transform transform12234 = gameObject12228.transform;
		SetObject(12234,transform12234);
		UnityEngine.Camera component12232 = gameObject12228.AddComponent<UnityEngine.Camera>();
		SetObject(12232,component12232);
		UnityEngine.AudioListener component12230 = gameObject12228.AddComponent<UnityEngine.AudioListener>();
		SetObject(12230,component12230);
		
		//Directional Light
		GameObject gameObject12236 = new GameObject();
		SetObject(12236, gameObject12236);
		Transform transform12240 = gameObject12236.transform;
		SetObject(12240,transform12240);
		UnityEngine.Light component12238 = gameObject12236.AddComponent<UnityEngine.Light>();
		SetObject(12238,component12238);
		

    }

    #endregion

    #region GameObjectFunctions
    protected override void InitialiseGameObjects()
    {
		mainCamera = mainCamera_Init();
		directionalLight = directionalLight_Init();

    }

	private GameObject mainCamera_Init()
	{
		GameObject gomainCamera_12228 = (GetObject(12228) as GameObject);
		gomainCamera_12228.name = "Main Camera";
		gomainCamera_12228.tag = "MainCamera";
		UnityEngine.Transform commainCamera_transform_0_12234 = (GetObject(12234) as UnityEngine.Transform);
		commainCamera_transform_0_12234.position = new Vector3(0f,1f,-10f);
		commainCamera_transform_0_12234.localPosition = new Vector3(0f,1f,-10f);
		commainCamera_transform_0_12234.eulerAngles = new Vector3(0f,0f,0f);
		commainCamera_transform_0_12234.localEulerAngles = new Vector3(0f,0f,0f);
		commainCamera_transform_0_12234.right = new Vector3(1f,0f,0f);
		commainCamera_transform_0_12234.up = new Vector3(0f,1f,0f);
		commainCamera_transform_0_12234.forward = new Vector3(0f,0f,1f);
		commainCamera_transform_0_12234.rotation = new Quaternion(0f,0f,0f,1f);
		commainCamera_transform_0_12234.localRotation = new Quaternion(0f,0f,0f,1f);
		commainCamera_transform_0_12234.localScale = new Vector3(1f,1f,1f);
		commainCamera_transform_0_12234.parent = null;
		commainCamera_transform_0_12234.hasChanged = true;
		commainCamera_transform_0_12234.hierarchyCapacity = 1;
		commainCamera_transform_0_12234.tag = "MainCamera";
		commainCamera_transform_0_12234.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.Camera commainCamera_camera_0_12232 = (GetObject(12232) as UnityEngine.Camera);
		commainCamera_camera_0_12232.nearClipPlane = 0.3f;
		commainCamera_camera_0_12232.farClipPlane = 1000f;
		commainCamera_camera_0_12232.fieldOfView = 60f;
		commainCamera_camera_0_12232.renderingPath = UnityEngine.RenderingPath.UsePlayerSettings;
		commainCamera_camera_0_12232.allowHDR = true;
		commainCamera_camera_0_12232.allowMSAA = true;
		commainCamera_camera_0_12232.allowDynamicResolution = false;
		commainCamera_camera_0_12232.forceIntoRenderTexture = false;
		commainCamera_camera_0_12232.orthographicSize = 5f;
		commainCamera_camera_0_12232.orthographic = false;
		commainCamera_camera_0_12232.opaqueSortMode = UnityEngine.Rendering.OpaqueSortMode.Default;
		commainCamera_camera_0_12232.transparencySortMode = UnityEngine.TransparencySortMode.Default;
		commainCamera_camera_0_12232.transparencySortAxis = new Vector3(0f,0f,1f);
		commainCamera_camera_0_12232.depth = -1f;
		commainCamera_camera_0_12232.aspect = 1.777778f;
		commainCamera_camera_0_12232.cullingMask = -1;
		commainCamera_camera_0_12232.eventMask = -1;
		commainCamera_camera_0_12232.layerCullSpherical = false;
		commainCamera_camera_0_12232.cameraType = UnityEngine.CameraType.Game;
		commainCamera_camera_0_12232.overrideSceneCullingMask = 0;
		commainCamera_camera_0_12232.layerCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		commainCamera_camera_0_12232.useOcclusionCulling = true;
		commainCamera_camera_0_12232.cullingMatrix = new Matrix4x4(new Vector4(0.9742786f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,1.0006f,1f),new Vector4(0f,-1.732051f,9.405821f,10f));
		commainCamera_camera_0_12232.backgroundColor = new Color(0.1921569f,0.3019608f,0.4745098f,0f);
		commainCamera_camera_0_12232.clearFlags = UnityEngine.CameraClearFlags.Skybox;
		commainCamera_camera_0_12232.depthTextureMode = UnityEngine.DepthTextureMode.None;
		commainCamera_camera_0_12232.clearStencilAfterLightingPass = false;
		commainCamera_camera_0_12232.usePhysicalProperties = false;
		commainCamera_camera_0_12232.sensorSize = new Vector2(36f,24f);
		commainCamera_camera_0_12232.lensShift = new Vector2(0f,0f);
		commainCamera_camera_0_12232.focalLength = 50f;
		commainCamera_camera_0_12232.gateFit = UnityEngine.Camera.GateFitMode.Horizontal;
		commainCamera_camera_0_12232.rect = new Rect(0f,0f,1f,1f);
		commainCamera_camera_0_12232.pixelRect = new Rect(0f,0f,304f,171f);
		commainCamera_camera_0_12232.targetTexture = null;
		commainCamera_camera_0_12232.targetDisplay = 0;
		commainCamera_camera_0_12232.worldToCameraMatrix = new Matrix4x4(new Vector4(1f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4(0f,0f,-1f,0f),new Vector4(0f,-1f,-10f,1f));
		commainCamera_camera_0_12232.projectionMatrix = new Matrix4x4(new Vector4(0.9742786f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,-1.0006f,-1f),new Vector4(0f,0f,-0.60018f,0f));
		commainCamera_camera_0_12232.nonJitteredProjectionMatrix = new Matrix4x4(new Vector4(0.9742786f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,-1.0006f,-1f),new Vector4(0f,0f,-0.60018f,0f));
		commainCamera_camera_0_12232.useJitteredProjectionMatrixForTransparentRendering = true;
		commainCamera_camera_0_12232.scene = GetScene();
		commainCamera_camera_0_12232.stereoSeparation = 0.022f;
		commainCamera_camera_0_12232.stereoConvergence = 10f;
		commainCamera_camera_0_12232.stereoTargetEye = UnityEngine.StereoTargetEyeMask.Both;
		commainCamera_camera_0_12232.enabled = true;
		commainCamera_camera_0_12232.tag = "MainCamera";
		commainCamera_camera_0_12232.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.AudioListener commainCamera_audiolistener_0_12230 = (GetObject(12230) as UnityEngine.AudioListener);
		commainCamera_audiolistener_0_12230.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Dynamic;
		commainCamera_audiolistener_0_12230.enabled = true;
		commainCamera_audiolistener_0_12230.tag = "MainCamera";
		commainCamera_audiolistener_0_12230.hideFlags = UnityEngine.HideFlags.None;
		return gomainCamera_12228;
	}
	private GameObject directionalLight_Init()
	{
		GameObject godirectionalLight_12236 = (GetObject(12236) as GameObject);
		godirectionalLight_12236.name = "Directional Light";
		godirectionalLight_12236.tag = "Untagged";
		UnityEngine.Transform comdirectionalLight_transform_0_12240 = (GetObject(12240) as UnityEngine.Transform);
		comdirectionalLight_transform_0_12240.position = new Vector3(0f,3f,0f);
		comdirectionalLight_transform_0_12240.localPosition = new Vector3(0f,3f,0f);
		comdirectionalLight_transform_0_12240.eulerAngles = new Vector3(50f,330f,0f);
		comdirectionalLight_transform_0_12240.localEulerAngles = new Vector3(50f,330f,0f);
		comdirectionalLight_transform_0_12240.right = new Vector3(0.8660254f,0f,0.4999999f);
		comdirectionalLight_transform_0_12240.up = new Vector3(-0.3830222f,0.6427876f,0.6634139f);
		comdirectionalLight_transform_0_12240.forward = new Vector3(-0.3213938f,-0.7660444f,0.5566705f);
		comdirectionalLight_transform_0_12240.rotation = new Quaternion(0.4082179f,-0.2345697f,0.1093816f,0.8754261f);
		comdirectionalLight_transform_0_12240.localRotation = new Quaternion(0.4082179f,-0.2345697f,0.1093816f,0.8754261f);
		comdirectionalLight_transform_0_12240.localScale = new Vector3(1f,1f,1f);
		comdirectionalLight_transform_0_12240.parent = null;
		comdirectionalLight_transform_0_12240.hasChanged = true;
		comdirectionalLight_transform_0_12240.hierarchyCapacity = 1;
		comdirectionalLight_transform_0_12240.tag = "Untagged";
		comdirectionalLight_transform_0_12240.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.Light comdirectionalLight_light_0_12238 = (GetObject(12238) as UnityEngine.Light);
		comdirectionalLight_light_0_12238.type = UnityEngine.LightType.Directional;
		comdirectionalLight_light_0_12238.spotAngle = 30f;
		comdirectionalLight_light_0_12238.innerSpotAngle = 21.80208f;
		comdirectionalLight_light_0_12238.color = new Color(1f,0.9568627f,0.8392157f,1f);
		comdirectionalLight_light_0_12238.colorTemperature = 6570f;
		comdirectionalLight_light_0_12238.intensity = 1f;
		comdirectionalLight_light_0_12238.bounceIntensity = 1f;
		comdirectionalLight_light_0_12238.useBoundingSphereOverride = false;
		comdirectionalLight_light_0_12238.boundingSphereOverride = new Vector4(0f,0f,0f,0f);
		comdirectionalLight_light_0_12238.shadowCustomResolution = -1;
		comdirectionalLight_light_0_12238.shadowBias = 0.05f;
		comdirectionalLight_light_0_12238.shadowNormalBias = 0.4f;
		comdirectionalLight_light_0_12238.shadowNearPlane = 0.2f;
		comdirectionalLight_light_0_12238.useShadowMatrixOverride = false;
		comdirectionalLight_light_0_12238.shadowMatrixOverride = new Matrix4x4(new Vector4(1f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4(0f,0f,1f,0f),new Vector4(0f,0f,0f,1f));
		comdirectionalLight_light_0_12238.range = 10f;
		comdirectionalLight_light_0_12238.flare = null;
		comdirectionalLight_light_0_12238.bakingOutput = default(UnityEngine.LightBakingOutput);
		comdirectionalLight_light_0_12238.cullingMask = -1;
		comdirectionalLight_light_0_12238.renderingLayerMask = 1;
		comdirectionalLight_light_0_12238.lightShadowCasterMode = UnityEngine.LightShadowCasterMode.Default;
		comdirectionalLight_light_0_12238.shadowRadius = 0f;
		comdirectionalLight_light_0_12238.shadowAngle = 0f;
		comdirectionalLight_light_0_12238.shadows = UnityEngine.LightShadows.Soft;
		comdirectionalLight_light_0_12238.shadowStrength = 1f;
		comdirectionalLight_light_0_12238.shadowResolution = UnityEngine.Rendering.LightShadowResolution.FromQualitySettings;
		comdirectionalLight_light_0_12238.layerShadowCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		comdirectionalLight_light_0_12238.cookieSize = 10f;
		comdirectionalLight_light_0_12238.cookie = null;
		comdirectionalLight_light_0_12238.renderMode = UnityEngine.LightRenderMode.Auto;
		comdirectionalLight_light_0_12238.areaSize = new Vector2(1f,1f);
		comdirectionalLight_light_0_12238.lightmapBakeType = UnityEngine.LightmapBakeType.Realtime;
		comdirectionalLight_light_0_12238.enabled = true;
		comdirectionalLight_light_0_12238.tag = "Untagged";
		comdirectionalLight_light_0_12238.hideFlags = UnityEngine.HideFlags.None;
		return godirectionalLight_12236;
	}

    #endregion

    #region Variables

	GameObject mainCamera;
	GameObject directionalLight;

    #endregion
}
