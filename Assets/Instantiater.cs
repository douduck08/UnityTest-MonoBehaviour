using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiater : MonoBehaviour {

    public GameObject UnitPrefab;
    private GameObject tmp;
    bool first = true;

    void Awake() {
        // Debug.Log("=== Instantiate in Awake ===");
        // tmp = GameObject.Instantiate(UnitPrefab);
        // Debug.Log("=== Instantiate in Awake ===");

        // Debug.Log("=== Destroy in Awake ===");
        // GameObject.Destroy(tmp);
        // Debug.Log("=== Destroy in Awake ===");
    }

    void Start () {
        // Debug.Log("=== Instantiate in Start ===");
        // tmp = GameObject.Instantiate(UnitPrefab);
        // Debug.Log("=== Instantiate in Start ===");

        // Debug.Log("=== Destroy in Start ===");
        // GameObject.Destroy(tmp);
        // Debug.Log("=== Destroy in Start ===");
    }

    void Update() {
        // if (first) {
        //     first = false;
        //     Debug.Log("=== Instantiate in Update ===");
        // tmp = GameObject.Instantiate(UnitPrefab);
        // Debug.Log("=== Instantiate in Update ===");
        // 
        // Debug.Log("=== Destroy in Update ===");
        // GameObject.Destroy(tmp);
        // Debug.Log("=== Destroy in Update ===");
        // }
    }

}
