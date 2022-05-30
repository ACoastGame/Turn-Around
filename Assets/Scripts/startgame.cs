using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour {
    private int sceneToContinue;

    // Use this for initialization
    void Start () {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneToContinue != 0)
        {
            SceneManager.LoadScene(sceneToContinue);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
