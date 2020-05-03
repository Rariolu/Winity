
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
		GameObject gameObject12548 = new GameObject();
		unityObjectMap.Add(12548,gameObject12548);
		UnityEngine.Transform component12554 = gameObject12548.AddComponent<UnityEngine.Transform>();
		unityObjectMap.Add(12554,component12554);
		UnityEngine.Camera component12552 = gameObject12548.AddComponent<UnityEngine.Camera>();
		unityObjectMap.Add(12552,component12552);
		UnityEngine.AudioListener component12550 = gameObject12548.AddComponent<UnityEngine.AudioListener>();
		unityObjectMap.Add(12550,component12550);
		GameObject gameObject12542 = new GameObject();
		unityObjectMap.Add(12542,gameObject12542);
		UnityEngine.Transform component12546 = gameObject12542.AddComponent<UnityEngine.Transform>();
		unityObjectMap.Add(12546,component12546);
		UnityEngine.Light component12544 = gameObject12542.AddComponent<UnityEngine.Light>();
		unityObjectMap.Add(12544,component12544);
		GameObject gameObject12538 = new GameObject();
		unityObjectMap.Add(12538,gameObject12538);
		UnityEngine.Transform component12540 = gameObject12538.AddComponent<UnityEngine.Transform>();
		unityObjectMap.Add(12540,component12540);
		GameObject gameObject12518 = new GameObject();
		unityObjectMap.Add(12518,gameObject12518);
		UnityEngine.Transform component12520 = gameObject12518.AddComponent<UnityEngine.Transform>();
		unityObjectMap.Add(12520,component12520);
		GameObject gameObject12522 = new GameObject();
		unityObjectMap.Add(12522,gameObject12522);
		UnityEngine.Transform component12524 = gameObject12522.AddComponent<UnityEngine.Transform>();
		unityObjectMap.Add(12524,component12524);
		NewBehaviourScript1 component12526 = gameObject12522.AddComponent<NewBehaviourScript1>();
		unityObjectMap.Add(12526,component12526);
		GameObject gameObject12534 = new GameObject();
		unityObjectMap.Add(12534,gameObject12534);
		UnityEngine.Transform component12536 = gameObject12534.AddComponent<UnityEngine.Transform>();
		unityObjectMap.Add(12536,component12536);
		GameObject gameObject12528 = new GameObject();
		unityObjectMap.Add(12528,gameObject12528);
		UnityEngine.Transform component12530 = gameObject12528.AddComponent<UnityEngine.Transform>();
		unityObjectMap.Add(12530,component12530);
		UnityEngine.AudioSource component12532 = gameObject12528.AddComponent<UnityEngine.AudioSource>();
		unityObjectMap.Add(12532,component12532);

    }

    #endregion

    #region GameObjectFunctions

	private GameObject mainCamera_Init()
	{
		GameObject mainCamera = (unityObjectMap[12548] as GameObject);
		mainCamera.name = "Main Camera";
		mainCamera.tag = "MainCamera";
		UnityEngine.Camera mainCamera_camera_0 = (unityObjectMap[12552] as UnityEngine.Camera);
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
		mainCamera_camera_0.name = "Main Camera";
		mainCamera_camera_0.hideFlags = UnityEngine.HideFlags.None;
		UnityEngine.AudioListener mainCamera_audiolistener_0 = (unityObjectMap[12550] as UnityEngine.AudioListener);
		mainCamera_audiolistener_0.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Dynamic;
		mainCamera_audiolistener_0.enabled = true;
		mainCamera_audiolistener_0.tag = "MainCamera";
		mainCamera_audiolistener_0.name = "Main Camera";
		mainCamera_audiolistener_0.hideFlags = UnityEngine.HideFlags.None;
		return mainCamera;
	}
	private GameObject directionalLight_Init()
	{
		GameObject directionalLight = (unityObjectMap[12542] as GameObject);
		directionalLight.name = "Directional Light";
		directionalLight.tag = "Untagged";
		UnityEngine.Light directionalLight_light_0 = (unityObjectMap[12544] as UnityEngine.Light);
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
		directionalLight_light_0.renderMode = UnityEngine.LightRenderMode.Auto;
		directionalLight_light_0.areaSize = new Vector2(1f,1f);
		directionalLight_light_0.lightmapBakeType = UnityEngine.LightmapBakeType.Realtime;
		directionalLight_light_0.enabled = true;
		directionalLight_light_0.tag = "Untagged";
		directionalLight_light_0.name = "Directional Light";
		directionalLight_light_0.hideFlags = UnityEngine.HideFlags.None;
		{
			GameObject deathtoameriCa = (unityObjectMap[12542] as GameObject);
			deathtoameriCa.name = "deathToAmeri ca";
			deathtoameriCa.tag = "Untagged";
			deathtoameriCa.transform.parent = directionalLight.transform;
		}
		return directionalLight;
	}
	private GameObject blep_Init()
	{
		GameObject blep = (unityObjectMap[12518] as GameObject);
		blep.name = "blep";
		blep.tag = "Untagged";
		{
			GameObject gameobject = (unityObjectMap[12518] as GameObject);
			gameobject.name = "GameObject";
			gameobject.tag = "Untagged";
			gameobject.transform.parent = blep.transform;
			NewBehaviourScript1 gameobject_newbehaviourscript1_0 = (unityObjectMap[12526] as NewBehaviourScript1);
			gameobject_newbehaviourscript1_0.useGUILayout = true;
			gameobject_newbehaviourscript1_0.runInEditMode = false;
			gameobject_newbehaviourscript1_0.enabled = true;
			gameobject_newbehaviourscript1_0.tag = "Untagged";
			gameobject_newbehaviourscript1_0.name = "GameObject";
			gameobject_newbehaviourscript1_0.hideFlags = UnityEngine.HideFlags.None;
			gameobject_newbehaviourscript1_0.die = "die";
			gameobject_newbehaviourscript1_0.rir = new System.Int32[] { 3, 76, 42 };
			gameobject_newbehaviourscript1_0.testObj = (unityObjectMap[12548] as UnityEngine.GameObject);
			gameobject_newbehaviourscript1_0.testObj2 = (unityObjectMap[12542] as UnityEngine.GameObject);
			GameObject gameobject_1_ = (unityObjectMap[12518] as GameObject);
			gameobject_1_.name = "GameObject (1)";
			gameobject_1_.tag = "Untagged";
			gameobject_1_.transform.parent = blep.transform;
			{
				GameObject audioSource = (unityObjectMap[12534] as GameObject);
				audioSource.name = "Audio Source";
				audioSource.tag = "Untagged";
				audioSource.transform.parent = gameobject_1_.transform;
				UnityEngine.AudioSource audioSource_audiosource_0 = (unityObjectMap[12532] as UnityEngine.AudioSource);
				audioSource_audiosource_0.volume = 1f;
				audioSource_audiosource_0.pitch = 1f;
				audioSource_audiosource_0.time = 0f;
				audioSource_audiosource_0.timeSamples = 0;
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
				audioSource_audiosource_0.name = "Audio Source";
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
