﻿using UnityEngine;
using System.Collections;

public class StartGameScript : MonoBehaviour
{
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Naming");
    }
}
