using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void KeluarGame()
    {
        Application.Quit();
        //Debug.Log("Keluar");
    }
}
