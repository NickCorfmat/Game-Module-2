using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager: MonoBehaviour {
    public void PlayGame() {
        SceneManager.LoadScene("PlayScene");
    }

    public void PlayCredits() {
        SceneManager.LoadScene("CreditScene");
    }

    public void ReturnToMenu() {
        SceneManager.LoadScene("MenuScene");
    }
}
