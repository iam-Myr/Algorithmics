using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement; // Library used to manage scenes

public class SceneChange : MonoBehaviour
{
    //Name of the scene that needs to be relaunched
    public string sceneName;


    void OnTriggerEnter()
    {
        //Relaunching the scene
        EditorSceneManager.LoadScene(sceneName);
    }
}

