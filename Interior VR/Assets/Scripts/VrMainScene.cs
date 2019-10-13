using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VrMainScene : MonoBehaviour {

    void Awake(){
        UnityEngine.XR.XRSettings.enabled = false;
    }

    public void LoadMagixBox(){
        SceneManager.LoadScene (1);
    }

    public void LoadVrCardBoard(){
        SceneManager.LoadScene (2);
    }
}
