 using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject tryagainUI;
    public GameObject PlayerCharacter;

    public GameObject PlayButton;
    public PlayerControler Player_Controler;

    static int targetFrameRate = 30;

    void Start()
    {
        // Initial setup
        Application.targetFrameRate = targetFrameRate;
    }

    public void playGame()
    { 
        Player_Controler.enabled = true;
        PlayButton.SetActive(false);

        //play the button click sound
        Sound.playSound("button sound");
    }


    public void Playerdead()
    {
        PlayerCharacter.SetActive(false);

        //set  tryagainUI image
        tryagainUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //play the button click sound
        Sound.playSound("button sound");
    }
}
