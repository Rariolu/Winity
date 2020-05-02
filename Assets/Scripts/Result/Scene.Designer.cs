
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

partial class phoenix
{
    #region GeneratedCode

    private void InitialiseComponent()
    {//beep
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
		mainCamera = mainCamera_Init();
		directionalLight = directionalLight_Init();
		blep = blep_Init();

    }

    #endregion

    #region GameObjectFunctions

	private GameObject mainCamera_Init()
	{
		GameObject mainCamera = new GameObject();
		mainCamera.name = "Main Camera";
		mainCamera.tag = "MainCamera";
		UnityEngine.Camera mainCamera_camera_0 = mainCamera.AddComponent<UnityEngine.Camera>();
		/*
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
		mainCamera_camera_0.aspect = 1.773481f;
		mainCamera_camera_0.cullingMask = -1;
		mainCamera_camera_0.eventMask = -1;
		mainCamera_camera_0.layerCullSpherical = false;
		mainCamera_camera_0.cameraType = UnityEngine.CameraType.Game;
		mainCamera_camera_0.overrideSceneCullingMask = 0;
		mainCamera_camera_0.layerCullDistances = new System.Single[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
		mainCamera_camera_0.useOcclusionCulling = true;
		mainCamera_camera_0.cullingMatrix = 0.97664	0.00000	0.00000	0.00000
0.00000	1.73205	0.00000	-1.73205
0.00000	0.00000	1.00060	9.40582
0.00000	0.00000	1.00000	10.00000
;
		mainCamera_camera_0.backgroundColor = RGBA(0.192, 0.302, 0.475, 0.000);
		mainCamera_camera_0.clearFlags = UnityEngine.CameraClearFlags.Skybox;
		mainCamera_camera_0.depthTextureMode = UnityEngine.DepthTextureMode.None;
		mainCamera_camera_0.clearStencilAfterLightingPass = false;
		mainCamera_camera_0.usePhysicalProperties = false;
		mainCamera_camera_0.sensorSize = new Vector2(36f,24f);
		mainCamera_camera_0.lensShift = new Vector2(0f,0f);
		mainCamera_camera_0.focalLength = 50f;
		mainCamera_camera_0.gateFit = UnityEngine.Camera+GateFitMode.Horizontal;
		mainCamera_camera_0.rect = (x:0.00, y:0.00, width:1.00, height:1.00);
		mainCamera_camera_0.pixelRect = (x:0.00, y:0.00, width:321.00, height:181.00);
		mainCamera_camera_0.targetDisplay = 0;
		mainCamera_camera_0.worldToCameraMatrix = 1.00000	0.00000	0.00000	0.00000
0.00000	1.00000	0.00000	-1.00000
0.00000	0.00000	-1.00000	-10.00000
0.00000	0.00000	0.00000	1.00000
;
		mainCamera_camera_0.projectionMatrix = 0.97664	0.00000	0.00000	0.00000
0.00000	1.73205	0.00000	0.00000
0.00000	0.00000	-1.00060	-0.60018
0.00000	0.00000	-1.00000	0.00000
;
		mainCamera_camera_0.nonJitteredProjectionMatrix = 0.97664	0.00000	0.00000	0.00000
0.00000	1.73205	0.00000	0.00000
0.00000	0.00000	-1.00060	-0.60018
0.00000	0.00000	-1.00000	0.00000
;
		mainCamera_camera_0.useJitteredProjectionMatrixForTransparentRendering = true;
		mainCamera_camera_0.scene = UnityEngine.SceneManagement.Scene;
		mainCamera_camera_0.stereoSeparation = 0.022f;
		mainCamera_camera_0.stereoConvergence = 10f;
		mainCamera_camera_0.stereoTargetEye = UnityEngine.StereoTargetEyeMask.Both;
		mainCamera_camera_0.enabled = true;
		mainCamera_camera_0.tag = "MainCamera";
		mainCamera_camera_0.name = "Main Camera";
		mainCamera_camera_0.hideFlags = UnityEngine.HideFlags.None;
		*/
		UnityEngine.AudioListener mainCamera_audiolistener_0 = mainCamera.AddComponent<UnityEngine.AudioListener>();
		/*
		mainCamera_audiolistener_0.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Dynamic;
		mainCamera_audiolistener_0.enabled = true;
		mainCamera_audiolistener_0.tag = "MainCamera";
		mainCamera_audiolistener_0.name = "Main Camera";
		mainCamera_audiolistener_0.hideFlags = UnityEngine.HideFlags.None;
		*/
		return mainCamera;
	}
	private GameObject directionalLight_Init()
	{
		GameObject directionalLight = new GameObject();
		directionalLight.name = "Directional Light";
		directionalLight.tag = "Untagged";
		UnityEngine.Light directionalLight_light_0 = directionalLight.AddComponent<UnityEngine.Light>();
		/*
		directionalLight_light_0.type = UnityEngine.LightType.Directional;
		directionalLight_light_0.spotAngle = 30f;
		directionalLight_light_0.innerSpotAngle = 21.80208f;
		directionalLight_light_0.color = RGBA(1.000, 0.957, 0.839, 1.000);
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
		directionalLight_light_0.shadowMatrixOverride = 1.00000	0.00000	0.00000	0.00000
0.00000	1.00000	0.00000	0.00000
0.00000	0.00000	1.00000	0.00000
0.00000	0.00000	0.00000	1.00000
;
		directionalLight_light_0.range = 10f;
		directionalLight_light_0.bakingOutput = UnityEngine.LightBakingOutput;
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
		*/
		{
			GameObject deathtoameriCa = new GameObject();
			deathtoameriCa.name = "deathToAmeri ca";
			deathtoameriCa.tag = "Untagged";
			deathtoameriCa.transform.parent = directionalLight.transform;
		}
		return directionalLight;
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
			/*
			gameobject_newbehaviourscript1_0.useGUILayout = true;
			gameobject_newbehaviourscript1_0.runInEditMode = false;
			gameobject_newbehaviourscript1_0.enabled = true;
			gameobject_newbehaviourscript1_0.tag = "Untagged";
			gameobject_newbehaviourscript1_0.name = "GameObject";
			gameobject_newbehaviourscript1_0.hideFlags = UnityEngine.HideFlags.None;
			gameobject_newbehaviourscript1_0.die = "die";
			gameobject_newbehaviourscript1_0.rir = new System.Int32[] { 3, 76, 42 };
			gameobject_newbehaviourscript1_0.testObj = Main Camera (UnityEngine.GameObject);
			gameobject_newbehaviourscript1_0.testObj2 = Area Light (UnityEngine.GameObject);
			*/
			GameObject gameobject_1_ = new GameObject();
			gameobject_1_.name = "GameObject (1)";
			gameobject_1_.tag = "Untagged";
			gameobject_1_.transform.parent = blep.transform;
			{
				GameObject audioSource = new GameObject();
				audioSource.name = "Audio Source";
				audioSource.tag = "Untagged";
				audioSource.transform.parent = gameobject_1_.transform;
				UnityEngine.AudioSource audioSource_audiosource_0 = audioSource.AddComponent<UnityEngine.AudioSource>();
				/*
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
				*/
			}
		}
		return blep;
	}


    #endregion

    #region Variables

    Scene scene;
	GameObject mainCamera;
	GameObject directionalLight;
	GameObject blep;


    #endregion
}
