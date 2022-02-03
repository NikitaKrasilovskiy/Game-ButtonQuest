using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScenes : MonoBehaviour
{
    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Tower1");
    }
    public void start()
    {
        StartCoroutine(StartWait());
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void level2()
    {
        SceneManager.LoadScene("Tower2");
    }
    public void level3()
    {
        SceneManager.LoadScene("Tower3");
    }
    public void level4()
    {
        SceneManager.LoadScene("Tower4");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
