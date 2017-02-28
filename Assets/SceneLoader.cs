using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    private void Start() {
        GameObject.DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += SceneLoaded;
        SceneManager.sceneUnloaded += SceneUnloaded;
        SceneManager.activeSceneChanged += ActiveSceneChanged;
    }

    private void SceneLoaded (Scene scene, LoadSceneMode mode) {
        Debug.Log("SceneLoaded");
    }

    private void SceneUnloaded(Scene scene) {
        Debug.Log("SceneUnoaded");
    }

    private void ActiveSceneChanged(Scene sceneA, Scene sceneB) {
        Debug.Log("ActiveSceneChanged");
    }

    public void ReloadScene() {
        Debug.Log("=== ReloadScene Start ===");
        StartCoroutine(StartLoadScene("main"));
    }

    private IEnumerator StartLoadScene(string sSceneName) {
        AsyncOperation op = SceneManager.LoadSceneAsync(sSceneName, LoadSceneMode.Single);
        while (!op.isDone) {
            yield return null;
        }
        Debug.Log("=== ReloadScene End ===");
    }
}
