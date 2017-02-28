using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUnit : MonoBehaviour {

    public int Num = 10;

    bool first = true;
    bool firstlate = true;

    void Awake() {
        Debug.Log(name + " Awake, Num = " + Num);
    }

    void Start () {
        Debug.Log(name + " Start, Num = " + Num + "(Frame: " + Time.frameCount);
    }

    void OnEnable() {
        Debug.Log(name + " OnEnable, Num = " + Num);
    }

    void OnDisable() {
        Debug.Log(name + " OnDisable" );
    }

    void Update() {
        if (first) {
            first = false;
            Debug.Log(name + " Update (Frame: " + Time.frameCount);
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
