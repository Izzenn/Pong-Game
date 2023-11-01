using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titlescreen : MonoBehaviour
{
    // Start is called before the first frame update

    public void play()
    {
        SceneManager.LoadScene("Player vs Player");
    }
    public void close()
    {
        Application.Quit();
    }
    public void easy()
    {
        SceneManager.LoadScene("Easy");
    }
    public void medium()
    {
        SceneManager.LoadScene("Medium");
    }
    public void hard()
    {
        SceneManager.LoadScene("Hard");
    }
}