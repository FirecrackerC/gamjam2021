using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartButton()
    {
        //change scene to game.
        SceneManager.LoadScene("TestScen");
    }

    public void InfoButton()
    {
        //change scene to info
    }

    public void ExitButton()
    {
        Debug.Log("The program has quit!");
        Application.Quit();
    }

}
