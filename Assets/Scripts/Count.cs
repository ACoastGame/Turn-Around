using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    //for the level counting
    public Text TotalCount;
    public Text BestCount;
    public Text CurentCount;

    static public int number;
    int score;

    //for the perfect text
    public GameObject[] perfectText;

    private void Start()
    {
        if (number > PlayerPrefs.GetInt("CountTotal", 1))
        {
            number = 0;
        }
        else
        {
            number = PlayerPrefs.GetInt("CountTotal", 1);
        }

        SetCountText();

        TotalCount.text = PlayerPrefs.GetInt("CountTotal", 1).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            //show the perfect text
            PerfectTextRandom();

            number++;
            score++;
            CurentCount.text = score.ToString();

            SetCountText();
        }
    }

    //for the random perfect text
    public void PerfectTextRandom()
    {
        GameObject selection = perfectText
            .Where(i => !i.activeSelf)
            .OrderBy(name => Random.value).FirstOrDefault();

        if (selection != null) selection.SetActive(true);
    }

    void SetCountText()
    {

        CurentCount.text = score.ToString();

        BestCount.text = number.ToString();

        if (number > PlayerPrefs.GetInt("CountTotal", 1))
        {
            PlayerPrefs.SetInt("CountTotal", number);
            TotalCount.text = number.ToString();
        }
        else
        {
            number = PlayerPrefs.GetInt("CountTotal", 1);
        }
    }
}
