using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}