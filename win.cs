using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{

    public int Map;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(Map);
    }
}
