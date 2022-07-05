using UnityEngine;
using UnityEngine.UI;

namespace ModularOptions {
	/// <summary>
	/// Add this to the GameObject of whatever button you want to load a scene with.
	/// </summary>
	[AddComponentMenu("Modular Options/Button/Load Scene")]
	[RequireComponent(typeof(Button))]
	public class LoadSceneButton : MonoBehaviour {

		[SceneRef] public string scene;
		SceneLoader sceneLoader;

		void Start() {
			sceneLoader = (SceneLoader) GameObject.Find("SceneLoader").GetComponent(typeof(SceneLoader));
		}

		void Awake(){
			GetComponent<Button>().onClick.AddListener(() => {
				// UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
				StartCoroutine(sceneLoader.LoadNextScene());
			});
		}
	}
}
