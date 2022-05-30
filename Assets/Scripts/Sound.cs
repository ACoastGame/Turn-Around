using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    public static AudioClip LevelComplete, Player, CoinSound, Buttons, BreadEat, TurnSound, HitSound1, HitSound2, HitSound3;

    static AudioSource audiosrc;

    // Use this for initialization
    void Start()
    {
        Buttons = Resources.Load<AudioClip>("button sound");
        LevelComplete = Resources.Load<AudioClip>("Level Complete");
        BreadEat = Resources.Load<AudioClip>("Bread Eat");
        Player = Resources.Load<AudioClip>("Player");
        CoinSound = Resources.Load<AudioClip>("Coin Sound");
        TurnSound = Resources.Load<AudioClip>("Turn Sound");
        HitSound1 = Resources.Load<AudioClip>("Hit Sound 1");
        HitSound2 = Resources.Load<AudioClip>("Hit Sound 2");
        HitSound3 = Resources.Load<AudioClip>("Hit Sound 3");
        audiosrc = GetComponent<AudioSource>();
    }

    public static void playSound(string clip)
    {
        switch (clip)
        {
            case "button sound":
                audiosrc.PlayOneShot(Buttons);

                break;

            case "LevelComplete":
                audiosrc.PlayOneShot(LevelComplete);

                break;

            case "Bread Eat":
                audiosrc.PlayOneShot(BreadEat);

                break;

            case "Player":
                audiosrc.PlayOneShot(Player);

                break;

            case "Coin Sound":
                audiosrc.PlayOneShot(CoinSound);

                break;

            case "Turn Sound":
                audiosrc.PlayOneShot(TurnSound);

                break;

            case "Hit Sound 1":
                audiosrc.PlayOneShot(HitSound1);

                break;

            case "Hit Sound 2":
                audiosrc.PlayOneShot(HitSound2);

                break;

            case "Hit Sound 3":
                audiosrc.PlayOneShot(HitSound3);

                break;
        }
    }
}
