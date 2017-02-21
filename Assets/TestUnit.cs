using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUnit : MonoBehaviour {

    bool first = true;
    bool firstlate = true;

    void Awake() {
        Debug.Log(name + " Awake");
    }

    void Start () {
        Debug.Log(name + " Start " + Time.frameCount);
    }

    void OnEnable() {
        Debug.Log(name + " OnEnable");
    }

    void OnDisable() {
        Debug.Log(name + " OnDisable" );
    }

    void Update() {
        if (first) {
            first = false;
            Debug.Log(name + " Update " + Time.frameCount);
        }
    }

    void LateUpdate() {
        if (firstlate) {
            firstlate = false;
            Debug.Log(name + " LateUpdate " + Time.frameCount);
        }
    }

    void OnDestroy() {
        Debug.Log(name + " OnDestroy");
    }

    void OnApplicationQuit() {
        Debug.Log(name + " OnApplicationQuit");
    }
}
