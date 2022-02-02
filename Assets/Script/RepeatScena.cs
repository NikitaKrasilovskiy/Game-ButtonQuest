using UnityEngine;
using UnityEngine.SceneManagement;

public class RepeatScena : MonoBehaviour
{
    public void Repeat()
    {
        SceneManager.LoadScene("menu");
    }
}
