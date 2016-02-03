using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour 
{
    public void PlayGame()
    {
        Application.LoadLevel("MainScene");
    }

    public void Credits()
    {
        Application.LoadLevel("Credits");
    }

    public void BackToMain()
    {
        Application.LoadLevel("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
