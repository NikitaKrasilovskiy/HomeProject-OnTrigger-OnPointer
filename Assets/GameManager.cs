using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject buttonNew, textWin, buttonReload, textLose;
    public int a, i;

    void Update()
    {
        if (a >= 6)
        {
            buttonNew.SetActive(true);
            textWin.SetActive(true);
        }

        if (i <= -3)
        {
            buttonReload.SetActive(true);
            textLose.SetActive(true);
        }
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene("1");
    }
}
