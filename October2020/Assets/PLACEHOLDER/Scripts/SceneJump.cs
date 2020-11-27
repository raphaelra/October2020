﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJump : MonoBehaviour
{
   public void StartGame() {
       SceneManager.LoadScene("TraceryFable",LoadSceneMode.Single);
   }

   public void Credits() {
       SceneManager.LoadScene("Credits",LoadSceneMode.Single);
   }

   public void GoMenu() {
       SceneManager.LoadScene("Menu",LoadSceneMode.Single);
   }

   public void QuitGame() {
       Application.Quit();
   }
}
