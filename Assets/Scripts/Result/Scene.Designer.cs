
using System.Collections.Generic;
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
            scene = SceneManager.CreateScene("phoenix");
        }
        else
        {
            scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);
            scene.name = "phoenix";
        }
        SceneManager.SetActiveScene(scene);

        unityObjectMap = new Dictionary<int, Object>();
        MapObjects();
      
		mainCamera = mainCamera_Init();
		directionalLight = directionalLight_Init();
		blep = blep_Init();

    }

    #endregion

    #region ObjectMapping

    void MapObjects()
    {
		//Main Camera
		GameObject gameObject13200 = new GameObject();
		unityObjectMap.Add(13200,gameObject13200);
		Transform transform13206 = gameObject13200.transform;
		unityObjectMap.Add(13206,transform13206);
		UnityEngine.Camera component13204 = gameObject13200.AddComponent<UnityEngine.Camera>();
		unityObjectMap.Add(13204,component13204);
		UnityEngine.AudioListener component13202 = gameObject13200.AddComponent<UnityEngine.AudioListener>();
		unityObjectMap.Add(13202,component13202);
		
		//Directional Light
		GameObject gameObject13194 = new GameObject();
		unityObjectMap.Add(13194,gameObject13194);
		Transform transform13198 = gameObject13194.transform;
		unityObjectMap.Add(13198,transform13198);
		UnityEngine.Light component13196 = gameObject13194.AddComponent<UnityEngine.Light>();
		unityObjectMap.Add(13196,component13196);
		
		//deathToAmeri ca
		GameObject gameObject13190 = new GameObject();
		unityObjectMap.Add(13190,gameObject13190);
		Transform transform13192 = gameObject13190.transform;
		unityObjectMap.Add(13192,transform13192);
		
		//blep
		GameObject gameObject13170 = new GameObject();
		unityObjectMap.Add(13170,gameObject13170);
		Transform transform13172 = gameObject13170.transform;
		unityObjectMap.Add(13172,transform13172);
		
		//GameObject
		GameObject gameObject13174 = new GameObject();
		unityObjectMap.Add(13174,gameObject13174);
		Transform transform13176 = gameObject13174.transform;
		unityObjectMap.Add(13176,transform13176);
		NewBehaviourScript1 component13178 = gameObject13174.AddComponent<NewBehaviourScript1>();
		unityObjectMap.Add(13178,component13178);
		
		//GameObject (1)
		GameObject gameObject13186 = new GameObject();
		unityObjectMap.Add(13186,gameObject13186);
		Transform transform13188 = gameObject13186.transform;
		unityObjectMap.Add(13188,transform13188);
		
		//Audio Source
		GameObject gameObject13180 = new GameObject();
		unityObjectMap.Add(13180,gameObject13180);
		Transform transform13182 = gameObject13180.transform;
		unityObjectMap.Add(13182,transform13182);
		UnityEngine.AudioSource component13184 = gameObject13180.AddComponent<UnityEngine.AudioSource>();
		unityObjectMap.Add(13184,component13184);
		

    }

    #endregion

    #region GameObjectFunctions

	private GameObject mainCamera_Init()
	{
		GameObject mainCamera = (unityObjectMap[13200] as GameObject);
		mainCamera.name = "Main Camera";
		mainCamera.tag = "MainCamera";
		UnityEngine.Transform mainCamera_transform_0 = (unityObjectMap[13206] as UnityEngine.Transform);
		mainCamera_transform_0.position = new Vector3(0f,1f,-10f);
		mainCamera_transform_0.localPosition = new Vector3(0f,1f,-10f);
		mainCamera_transform_0.eulerAngles = new Vector3(0f,0f,0f);
		mainCamera_transform_0.localEulerAngles = new Vector3(0f,0f,0f);
		mainCamera_transform_0.right = new Vector3(1f,0f,0f);
		mainCamera_transform_0.up = new Vector3(0f,1f,0f);
		mainCamera_transform_0.forward = new Vector3(0f,0f,1f);
		mainCamera_transform_0.rotation = default(UnityEngine.Quaternion);
		mainCamera_transform_0.localRotation = default(UnityEngine.Quaternion);
		mainCamera_transform_0.localScale = new Vector3(1f,1f,1f);
		mainCamera_transform_0.parent = null;
		mainCamera_transform_0.hasChanged = true;
		mainCamera_transform_0.hierarchyCapacity = 1;
		mainCamera_transform_0.tag = "MainCamera";
		mainCamera_transform_0.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.Camera mainCamera_camera_0 = (unityObjectMap[13204] as UnityEngine.Camera);
		mainCamera_camera_0.nearClipPlane = 0.3f;
		mainCamera_camera_0.farClipPlane = 1000f;
		mainCamera_camera_0.fieldOfView = 60f;
		mainCamera_camera_0.renderingPath = UnityEngine.RenderingPath.UsePlayerSettings;
		mainCamera_camera_0.allowHDR = true;
		mainCamera_camera_0.allowMSAA = true;
		mainCamera_camera_0.allowDynamicResolution = false;
		mainCamera_camera_0.forceIntoRenderTexture = false;
		mainCamera_camera_0.orthographicSize = 5f;
		mainCamera_camera_0.orthographic = false;
		mainCamera_camera_0.opaqueSortMode = UnityEngine.Rendering.OpaqueSortMode.Default;
		mainCamera_camera_0.transparencySortMode = UnityEngine.TransparencySortMode.Default;
		mainCamera_camera_0.transparencySortAxis = new Vector3(0f,0f,1f);
		mainCamera_camera_0.depth = -1f;
		mainCamera_camera_0.aspect = 1.778481f;
		mainCamera_camera_0.cullingMask = -1;
		mainCamera_camera_0.eventMask = -1;
		mainCamera_camera_0.layerCullSpherical = false;
		mainCamera_camera_0.cameraType = UnityEngine.CameraType.Game;
		mainCamera_camera_0.overrideSceneCullingMask = default(System.UInt64);
		mainCamera_camera_0.layerCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		mainCamera_camera_0.useOcclusionCulling = true;
		mainCamera_camera_0.cullingMatrix = new Matrix4x4(new Vector4(0.9738933f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,1.0006f,1f),new Vector4(0f,-1.732051f,9.405821f,10f));
		mainCamera_camera_0.backgroundColor = new Color(0.1921569f,0.3019608f,0.4745098f,0f);
		mainCamera_camera_0.clearFlags = UnityEngine.CameraClearFlags.Skybox;
		mainCamera_camera_0.depthTextureMode = UnityEngine.DepthTextureMode.None;
		mainCamera_camera_0.clearStencilAfterLightingPass = false;
		mainCamera_camera_0.usePhysicalProperties = false;
		mainCamera_camera_0.sensorSize = new Vector2(36f,24f);
		mainCamera_camera_0.lensShift = new Vector2(0f,0f);
		mainCamera_camera_0.focalLength = 50f;
		mainCamera_camera_0.gateFit = UnityEngine.Camera.GateFitMode.Horizontal;
		mainCamera_camera_0.rect = new Rect(0f,0f,1f,1f);
		mainCamera_camera_0.pixelRect = new Rect(0f,0f,281f,158f);
		mainCamera_camera_0.targetTexture = null;
		mainCamera_camera_0.targetDisplay = 0;
		mainCamera_camera_0.worldToCameraMatrix = new Matrix4x4(new Vector4(1f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4(0f,0f,-1f,0f),new Vector4(0f,-1f,-10f,1f));
		mainCamera_camera_0.projectionMatrix = new Matrix4x4(new Vector4(0.9738933f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,-1.0006f,-1f),new Vector4(0f,0f,-0.60018f,0f));
		mainCamera_camera_0.nonJitteredProjectionMatrix = new Matrix4x4(new Vector4(0.9738933f,0f,0f,0f),new Vector4(0f,1.732051f,0f,0f),new Vector4(0f,0f,-1.0006f,-1f),new Vector4(0f,0f,-0.60018f,0f));
		mainCamera_camera_0.useJitteredProjectionMatrixForTransparentRendering = true;
		mainCamera_camera_0.scene = scene;
		mainCamera_camera_0.stereoSeparation = 0.022f;
		mainCamera_camera_0.stereoConvergence = 10f;
		mainCamera_camera_0.stereoTargetEye = UnityEngine.StereoTargetEyeMask.Both;
		mainCamera_camera_0.enabled = true;
		mainCamera_camera_0.tag = "MainCamera";
		mainCamera_camera_0.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.AudioListener mainCamera_audiolistener_0 = (unityObjectMap[13202] as UnityEngine.AudioListener);
		mainCamera_audiolistener_0.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Dynamic;
		mainCamera_audiolistener_0.enabled = true;
		mainCamera_audiolistener_0.tag = "MainCamera";
		mainCamera_audiolistener_0.hideFlags = UnityEngine.HideFlags.None;
		return mainCamera;
	}
	private GameObject directionalLight_Init()
	{
		GameObject directionalLight = (unityObjectMap[13194] as GameObject);
		directionalLight.name = "Directional Light";
		directionalLight.tag = "Untagged";
		UnityEngine.Transform directionalLight_transform_0 = (unityObjectMap[13198] as UnityEngine.Transform);
		directionalLight_transform_0.position = new Vector3(0f,3f,0f);
		directionalLight_transform_0.localPosition = new Vector3(0f,3f,0f);
		directionalLight_transform_0.eulerAngles = new Vector3(50f,330f,0f);
		directionalLight_transform_0.localEulerAngles = new Vector3(50f,330f,0f);
		directionalLight_transform_0.right = new Vector3(0.8660254f,0f,0.4999999f);
		directionalLight_transform_0.up = new Vector3(-0.3830222f,0.6427876f,0.6634139f);
		directionalLight_transform_0.forward = new Vector3(-0.3213938f,-0.7660444f,0.5566705f);
		directionalLight_transform_0.rotation = default(UnityEngine.Quaternion);
		directionalLight_transform_0.localRotation = default(UnityEngine.Quaternion);
		directionalLight_transform_0.localScale = new Vector3(1f,1f,1f);
		directionalLight_transform_0.parent = null;
		directionalLight_transform_0.hasChanged = true;
		directionalLight_transform_0.hierarchyCapacity = 2;
		directionalLight_transform_0.tag = "Untagged";
		directionalLight_transform_0.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.Light directionalLight_light_0 = (unityObjectMap[13196] as UnityEngine.Light);
		directionalLight_light_0.type = UnityEngine.LightType.Directional;
		directionalLight_light_0.spotAngle = 30f;
		directionalLight_light_0.innerSpotAngle = 21.80208f;
		directionalLight_light_0.color = new Color(1f,0.9568627f,0.8392157f,1f);
		directionalLight_light_0.colorTemperature = 6570f;
		directionalLight_light_0.intensity = 1f;
		directionalLight_light_0.bounceIntensity = 1f;
		directionalLight_light_0.useBoundingSphereOverride = false;
		directionalLight_light_0.boundingSphereOverride = new Vector4(0f,0f,0f,0f);
		directionalLight_light_0.shadowCustomResolution = -1;
		directionalLight_light_0.shadowBias = 0.05f;
		directionalLight_light_0.shadowNormalBias = 0.4f;
		directionalLight_light_0.shadowNearPlane = 0.2f;
		directionalLight_light_0.useShadowMatrixOverride = false;
		directionalLight_light_0.shadowMatrixOverride = new Matrix4x4(new Vector4(1f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4(0f,0f,1f,0f),new Vector4(0f,0f,0f,1f));
		directionalLight_light_0.range = 10f;
		directionalLight_light_0.flare = null;
		directionalLight_light_0.bakingOutput = default(UnityEngine.LightBakingOutput);
		directionalLight_light_0.cullingMask = -1;
		directionalLight_light_0.renderingLayerMask = 1;
		directionalLight_light_0.lightShadowCasterMode = UnityEngine.LightShadowCasterMode.Default;
		directionalLight_light_0.shadowRadius = 0f;
		directionalLight_light_0.shadowAngle = 0f;
		directionalLight_light_0.shadows = UnityEngine.LightShadows.Soft;
		directionalLight_light_0.shadowStrength = 1f;
		directionalLight_light_0.shadowResolution = UnityEngine.Rendering.LightShadowResolution.FromQualitySettings;
		directionalLight_light_0.layerShadowCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		directionalLight_light_0.cookieSize = 10f;
		directionalLight_light_0.cookie = null;
		directionalLight_light_0.renderMode = UnityEngine.LightRenderMode.Auto;
		directionalLight_light_0.areaSize = new Vector2(1f,1f);
		directionalLight_light_0.lightmapBakeType = UnityEngine.LightmapBakeType.Realtime;
		directionalLight_light_0.enabled = true;
		directionalLight_light_0.tag = "Untagged";
		directionalLight_light_0.hideFlags = UnityEngine.HideFlags.None;
		{
			GameObject deathtoameriCa = (unityObjectMap[13190] as GameObject);
			deathtoameriCa.name = "deathToAmeri ca";
			deathtoameriCa.tag = "Untagged";
			UnityEngine.Transform deathtoameriCa_transform_0 = (unityObjectMap[13192] as UnityEngine.Transform);
			deathtoameriCa_transform_0.position = new Vector3(0f,3f,0f);
			deathtoameriCa_transform_0.localPosition = new Vector3(0f,0f,0f);
			deathtoameriCa_transform_0.eulerAngles = new Vector3(50f,330f,0f);
			deathtoameriCa_transform_0.localEulerAngles = new Vector3(0f,0f,0f);
			deathtoameriCa_transform_0.right = new Vector3(0.8660254f,0f,0.4999999f);
			deathtoameriCa_transform_0.up = new Vector3(-0.3830222f,0.6427876f,0.6634139f);
			deathtoameriCa_transform_0.forward = new Vector3(-0.3213938f,-0.7660444f,0.5566705f);
			deathtoameriCa_transform_0.rotation = default(UnityEngine.Quaternion);
			deathtoameriCa_transform_0.localRotation = default(UnityEngine.Quaternion);
			deathtoameriCa_transform_0.localScale = new Vector3(1f,1f,1f);
			deathtoameriCa_transform_0.parent = (unityObjectMap[13198] as UnityEngine.Transform);
			deathtoameriCa_transform_0.hasChanged = true;
			deathtoameriCa_transform_0.hierarchyCapacity = 2;
			deathtoameriCa_transform_0.tag = "Untagged";
			deathtoameriCa_transform_0.hideFlags = UnityEngine.HideFlags.None;
		}
		return directionalLight;
	}
	private GameObject blep_Init()
	{
		GameObject blep = (unityObjectMap[13170] as GameObject);
		blep.name = "blep";
		blep.tag = "Untagged";
		UnityEngine.Transform blep_transform_0 = (unityObjectMap[13172] as UnityEngine.Transform);
		blep_transform_0.position = new Vector3(0f,0f,0f);
		blep_transform_0.localPosition = new Vector3(0f,0f,0f);
		blep_transform_0.eulerAngles = new Vector3(0f,0f,0f);
		blep_transform_0.localEulerAngles = new Vector3(0f,0f,0f);
		blep_transform_0.right = new Vector3(1f,0f,0f);
		blep_transform_0.up = new Vector3(0f,1f,0f);
		blep_transform_0.forward = new Vector3(0f,0f,1f);
		blep_transform_0.rotation = default(UnityEngine.Quaternion);
		blep_transform_0.localRotation = default(UnityEngine.Quaternion);
		blep_transform_0.localScale = new Vector3(1f,1f,1f);
		blep_transform_0.parent = null;
		blep_transform_0.hasChanged = true;
		blep_transform_0.hierarchyCapacity = 4;
		blep_transform_0.tag = "Untagged";
		blep_transform_0.hideFlags = UnityEngine.HideFlags.None;
		{
			GameObject gameobject = (unityObjectMap[13174] as GameObject);
			gameobject.name = "GameObject";
			gameobject.tag = "Untagged";
			UnityEngine.Transform gameobject_transform_0 = (unityObjectMap[13176] as UnityEngine.Transform);
			gameobject_transform_0.position = new Vector3(0f,0f,0f);
			gameobject_transform_0.localPosition = new Vector3(0f,0f,0f);
			gameobject_transform_0.eulerAngles = new Vector3(0f,0f,0f);
			gameobject_transform_0.localEulerAngles = new Vector3(0f,0f,0f);
			gameobject_transform_0.right = new Vector3(1f,0f,0f);
			gameobject_transform_0.up = new Vector3(0f,1f,0f);
			gameobject_transform_0.forward = new Vector3(0f,0f,1f);
			gameobject_transform_0.rotation = default(UnityEngine.Quaternion);
			gameobject_transform_0.localRotation = default(UnityEngine.Quaternion);
			gameobject_transform_0.localScale = new Vector3(1f,1f,1f);
			gameobject_transform_0.parent = (unityObjectMap[13172] as UnityEngine.Transform);
			gameobject_transform_0.hasChanged = true;
			gameobject_transform_0.hierarchyCapacity = 4;
			gameobject_transform_0.tag = "Untagged";
			gameobject_transform_0.hideFlags = UnityEngine.HideFlags.None;
			NewBehaviourScript1 gameobject_newbehaviourscript1_0 = (unityObjectMap[13178] as NewBehaviourScript1);
			gameobject_newbehaviourscript1_0.useGUILayout = true;
			gameobject_newbehaviourscript1_0.runInEditMode = false;
			gameobject_newbehaviourscript1_0.enabled = true;
			gameobject_newbehaviourscript1_0.tag = "Untagged";
			gameobject_newbehaviourscript1_0.hideFlags = UnityEngine.HideFlags.None;
			gameobject_newbehaviourscript1_0.die = "die";
			gameobject_newbehaviourscript1_0.rir = new System.Int32[] { 3, 76, 42 };
			gameobject_newbehaviourscript1_0.testObj = (unityObjectMap[13200] as UnityEngine.GameObject);
			GameObject gameobject_1_ = (unityObjectMap[13186] as GameObject);
			gameobject_1_.name = "GameObject (1)";
			gameobject_1_.tag = "Untagged";
			UnityEngine.Transform gameobject_1__transform_0 = (unityObjectMap[13188] as UnityEngine.Transform);
			gameobject_1__transform_0.position = new Vector3(0f,0f,0f);
			gameobject_1__transform_0.localPosition = new Vector3(0f,0f,0f);
			gameobject_1__transform_0.eulerAngles = new Vector3(0f,0f,0f);
			gameobject_1__transform_0.localEulerAngles = new Vector3(0f,0f,0f);
			gameobject_1__transform_0.right = new Vector3(1f,0f,0f);
			gameobject_1__transform_0.up = new Vector3(0f,1f,0f);
			gameobject_1__transform_0.forward = new Vector3(0f,0f,1f);
			gameobject_1__transform_0.rotation = default(UnityEngine.Quaternion);
			gameobject_1__transform_0.localRotation = default(UnityEngine.Quaternion);
			gameobject_1__transform_0.localScale = new Vector3(1f,1f,1f);
			gameobject_1__transform_0.parent = (unityObjectMap[13172] as UnityEngine.Transform);
			gameobject_1__transform_0.hasChanged = true;
			gameobject_1__transform_0.hierarchyCapacity = 4;
			gameobject_1__transform_0.tag = "Untagged";
			gameobject_1__transform_0.hideFlags = UnityEngine.HideFlags.None;
			{
				GameObject audioSource = (unityObjectMap[13180] as GameObject);
				audioSource.name = "Audio Source";
				audioSource.tag = "Untagged";
				UnityEngine.Transform audioSource_transform_0 = (unityObjectMap[13182] as UnityEngine.Transform);
				audioSource_transform_0.position = new Vector3(0f,0f,0f);
				audioSource_transform_0.localPosition = new Vector3(0f,0f,0f);
				audioSource_transform_0.eulerAngles = new Vector3(0f,0f,0f);
				audioSource_transform_0.localEulerAngles = new Vector3(0f,0f,0f);
				audioSource_transform_0.right = new Vector3(1f,0f,0f);
				audioSource_transform_0.up = new Vector3(0f,1f,0f);
				audioSource_transform_0.forward = new Vector3(0f,0f,1f);
				audioSource_transform_0.rotation = default(UnityEngine.Quaternion);
				audioSource_transform_0.localRotation = default(UnityEngine.Quaternion);
				audioSource_transform_0.localScale = new Vector3(1f,1f,1f);
				audioSource_transform_0.parent = (unityObjectMap[13188] as UnityEngine.Transform);
				audioSource_transform_0.hasChanged = true;
				audioSource_transform_0.hierarchyCapacity = 4;
				audioSource_transform_0.tag = "Untagged";
				audioSource_transform_0.hideFlags = UnityEngine.HideFlags.None;
				UnityEngine.AudioSource audioSource_audiosource_0 = (unityObjectMap[13184] as UnityEngine.AudioSource);
				audioSource_audiosource_0.volume = 1f;
				audioSource_audiosource_0.pitch = 1f;
				audioSource_audiosource_0.time = 0f;
				audioSource_audiosource_0.timeSamples = 0;
				audioSource_audiosource_0.clip = null;
				audioSource_audiosource_0.outputAudioMixerGroup = null;
				audioSource_audiosource_0.loop = false;
				audioSource_audiosource_0.ignoreListenerVolume = false;
				audioSource_audiosource_0.playOnAwake = true;
				audioSource_audiosource_0.ignoreListenerPause = false;
				audioSource_audiosource_0.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Auto;
				audioSource_audiosource_0.panStereo = 0f;
				audioSource_audiosource_0.spatialBlend = 0f;
				audioSource_audiosource_0.spatialize = false;
				audioSource_audiosource_0.spatializePostEffects = false;
				audioSource_audiosource_0.reverbZoneMix = 1f;
				audioSource_audiosource_0.bypassEffects = false;
				audioSource_audiosource_0.bypassListenerEffects = false;
				audioSource_audiosource_0.bypassReverbZones = false;
				audioSource_audiosource_0.dopplerLevel = 1f;
				audioSource_audiosource_0.spread = 0f;
				audioSource_audiosource_0.priority = 128;
				audioSource_audiosource_0.mute = false;
				audioSource_audiosource_0.minDistance = 1f;
				audioSource_audiosource_0.maxDistance = 500f;
				audioSource_audiosource_0.rolloffMode = UnityEngine.AudioRolloffMode.Logarithmic;
				audioSource_audiosource_0.enabled = true;
				audioSource_audiosource_0.tag = "Untagged";
				audioSource_audiosource_0.hideFlags = UnityEngine.HideFlags.None;
			}
		}
		return blep;
	}

    #endregion

    #region Variables

    Scene scene;
    Dictionary<int,Object> unityObjectMap;
	GameObject mainCamera;
	GameObject directionalLight;
	GameObject blep;

    #endregion
}
