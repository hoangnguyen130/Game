using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changesence1a : MonoBehaviour
{   
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    public int numberMap;
    public void ChangeScenes()
    {
        SceneManager.LoadScene(numberMap);
    }
}
