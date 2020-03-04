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
		/*
		main_camera_camera_0.nearClipPlane = 0.3f;
		main_camera_camera_0.farClipPlane = 1000f;
		main_camera_camera_0.fieldOfView = 60f;
		main_camera_camera_0.renderingPath = UnityEngine.RenderingPath.UsePlayerSettings;
		main_camera_camera_0.allowHDR = true;
		main_camera_camera_0.allowMSAA = true;
		main_camera_camera_0.allowDynamicResolution = false;
		main_camera_camera_0.forceIntoRenderTexture = false;
		main_camera_camera_0.orthographicSize = 5f;
		main_camera_camera_0.orthographic = false;
		main_camera_camera_0.opaqueSortMode = UnityEngine.Rendering.OpaqueSortMode.Default;
		main_camera_camera_0.transparencySortMode = UnityEngine.TransparencySortMode.Default;
		main_camera_camera_0.transparencySortAxis = (0.0, 0.0, 1.0);
		main_camera_camera_0.depth = -1f;
		main_camera_camera_0.aspect = 1.775956f;
		main_camera_camera_0.cullingMask = -1;
		main_camera_camera_0.eventMask = -1;
		main_camera_camera_0.layerCullSpherical = false;
		main_camera_camera_0.cameraType = UnityEngine.CameraType.Game;
		main_camera_camera_0.overrideSceneCullingMask = 0;
		main_camera_camera_0.layerCullDistances = System.Single[];
		main_camera_camera_0.useOcclusionCulling = true;
		main_camera_camera_0.cullingMatrix = 0.97528	0.00000	0.00000	0.00000
0.00000	1.73205	0.00000	-1.73205
0.00000	0.00000	1.00060	9.40582
0.00000	0.00000	1.00000	10.00000
;
		main_camera_camera_0.backgroundColor = RGBA(0.192, 0.302, 0.475, 0.000);
		main_camera_camera_0.clearFlags = UnityEngine.CameraClearFlags.Skybox;
		main_camera_camera_0.depthTextureMode = UnityEngine.DepthTextureMode.None;
		main_camera_camera_0.clearStencilAfterLightingPass = false;
		main_camera_camera_0.usePhysicalProperties = false;
		main_camera_camera_0.sensorSize = (36.0, 24.0);
		main_camera_camera_0.lensShift = (0.0, 0.0);
		main_camera_camera_0.focalLength = 50f;
		main_camera_camera_0.gateFit = UnityEngine.Camera+GateFitMode.Horizontal;
		main_camera_camera_0.rect = (x:0.00, y:0.00, width:1.00, height:1.00);
		main_camera_camera_0.pixelRect = (x:0.00, y:0.00, width:325.00, height:183.00);
		main_camera_camera_0.targetDisplay = 0;
		main_camera_camera_0.worldToCameraMatrix = 1.00000	0.00000	0.00000	0.00000
0.00000	1.00000	0.00000	-1.00000
0.00000	0.00000	-1.00000	-10.00000
0.00000	0.00000	0.00000	1.00000
;
		main_camera_camera_0.projectionMatrix = 0.97528	0.00000	0.00000	0.00000
0.00000	1.73205	0.00000	0.00000
0.00000	0.00000	-1.00060	-0.60018
0.00000	0.00000	-1.00000	0.00000
;
		main_camera_camera_0.nonJitteredProjectionMatrix = 0.97528	0.00000	0.00000	0.00000
0.00000	1.73205	0.00000	0.00000
0.00000	0.00000	-1.00060	-0.60018
0.00000	0.00000	-1.00000	0.00000
;
		main_camera_camera_0.useJitteredProjectionMatrixForTransparentRendering = true;
		main_camera_camera_0.scene = UnityEngine.SceneManagement.Scene;
		main_camera_camera_0.stereoSeparation = 0.022f;
		main_camera_camera_0.stereoConvergence = 10f;
		main_camera_camera_0.stereoTargetEye = UnityEngine.StereoTargetEyeMask.Both;
		main_camera_camera_0.enabled = true;
		main_camera_camera_0.tag = "MainCamera";
		main_camera_camera_0.name = "Main Camera";
		main_camera_camera_0.hideFlags = UnityEngine.HideFlags.None;
		*/
		UnityEngine.AudioListener main_camera_audiolistener_0 = main_camera.AddComponent<UnityEngine.AudioListener>();
		/*
		main_camera_audiolistener_0.volume = 1f;
		main_camera_audiolistener_0.pause = false;
		main_camera_audiolistener_0.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Dynamic;
		main_camera_audiolistener_0.enabled = true;
		main_camera_audiolistener_0.tag = "MainCamera";
		main_camera_audiolistener_0.name = "Main Camera";
		main_camera_audiolistener_0.hideFlags = UnityEngine.HideFlags.None;
		*/
		return main_camera;
	}
	private GameObject directional_light_Init()
	{
		GameObject directional_light = new GameObject();
		directional_light.name = "Directional Light";
		directional_light.tag = "Untagged";
		UnityEngine.Light directional_light_light_0 = directional_light.AddComponent<UnityEngine.Light>();
		/*
		directional_light_light_0.type = UnityEngine.LightType.Directional;
		directional_light_light_0.spotAngle = 30f;
		directional_light_light_0.innerSpotAngle = 21.80208f;
		directional_light_light_0.color = RGBA(1.000, 0.957, 0.839, 1.000);
		directional_light_light_0.colorTemperature = 6570f;
		directional_light_light_0.intensity = 1f;
		directional_light_light_0.bounceIntensity = 1f;
		directional_light_light_0.useBoundingSphereOverride = false;
		directional_light_light_0.boundingSphereOverride = (0.0, 0.0, 0.0, 0.0);
		directional_light_light_0.shadowCustomResolution = -1;
		directional_light_light_0.shadowBias = 0.05f;
		directional_light_light_0.shadowNormalBias = 0.4f;
		directional_light_light_0.shadowNearPlane = 0.2f;
		directional_light_light_0.useShadowMatrixOverride = false;
		directional_light_light_0.shadowMatrixOverride = 1.00000	0.00000	0.00000	0.00000
0.00000	1.00000	0.00000	0.00000
0.00000	0.00000	1.00000	0.00000
0.00000	0.00000	0.00000	1.00000
;
		directional_light_light_0.range = 10f;
		directional_light_light_0.bakingOutput = UnityEngine.LightBakingOutput;
		directional_light_light_0.cullingMask = -1;
		directional_light_light_0.renderingLayerMask = 1;
		directional_light_light_0.lightShadowCasterMode = UnityEngine.LightShadowCasterMode.Default;
		directional_light_light_0.shadowRadius = 0f;
		directional_light_light_0.shadowAngle = 0f;
		directional_light_light_0.shadows = UnityEngine.LightShadows.Soft;
		directional_light_light_0.shadowStrength = 1f;
		directional_light_light_0.shadowResolution = UnityEngine.Rendering.LightShadowResolution.FromQualitySettings;
		directional_light_light_0.layerShadowCullDistances = System.Single[];
		directional_light_light_0.cookieSize = 10f;
		directional_light_light_0.renderMode = UnityEngine.LightRenderMode.Auto;
		directional_light_light_0.areaSize = (1.0, 1.0);
		directional_light_light_0.lightmapBakeType = UnityEngine.LightmapBakeType.Realtime;
		directional_light_light_0.enabled = true;
		directional_light_light_0.tag = "Untagged";
		directional_light_light_0.name = "Directional Light";
		directional_light_light_0.hideFlags = UnityEngine.HideFlags.None;
		*/
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
			/*
			gameobject_newbehaviourscript1_0.useGUILayout = true;
			gameobject_newbehaviourscript1_0.runInEditMode = false;
			gameobject_newbehaviourscript1_0.enabled = true;
			gameobject_newbehaviourscript1_0.tag = "Untagged";
			gameobject_newbehaviourscript1_0.name = "GameObject";
			gameobject_newbehaviourscript1_0.hideFlags = UnityEngine.HideFlags.None;
			gameobject_newbehaviourscript1_0.die = "die";
			*/
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
				/*
				audio_source_audiosource_0.volume = 1f;
				audio_source_audiosource_0.pitch = 1f;
				audio_source_audiosource_0.time = 0f;
				audio_source_audiosource_0.timeSamples = 0;
				audio_source_audiosource_0.loop = false;
				audio_source_audiosource_0.ignoreListenerVolume = false;
				audio_source_audiosource_0.playOnAwake = true;
				audio_source_audiosource_0.ignoreListenerPause = false;
				audio_source_audiosource_0.velocityUpdateMode = UnityEngine.AudioVelocityUpdateMode.Auto;
				audio_source_audiosource_0.panStereo = 0f;
				audio_source_audiosource_0.spatialBlend = 0f;
				audio_source_audiosource_0.spatialize = false;
				audio_source_audiosource_0.spatializePostEffects = false;
				audio_source_audiosource_0.reverbZoneMix = 1f;
				audio_source_audiosource_0.bypassEffects = false;
				audio_source_audiosource_0.bypassListenerEffects = false;
				audio_source_audiosource_0.bypassReverbZones = false;
				audio_source_audiosource_0.dopplerLevel = 1f;
				audio_source_audiosource_0.spread = 0f;
				audio_source_audiosource_0.priority = 128;
				audio_source_audiosource_0.mute = false;
				audio_source_audiosource_0.minDistance = 1f;
				audio_source_audiosource_0.maxDistance = 500f;
				audio_source_audiosource_0.rolloffMode = UnityEngine.AudioRolloffMode.Logarithmic;
				audio_source_audiosource_0.enabled = true;
				audio_source_audiosource_0.tag = "Untagged";
				audio_source_audiosource_0.name = "Audio Source";
				audio_source_audiosource_0.hideFlags = UnityEngine.HideFlags.None;
				*/
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
