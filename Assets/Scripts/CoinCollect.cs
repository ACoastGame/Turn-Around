using System.Linq;
using UnityEngine;

public class CoinCollect : MonoBehaviour {

    //for the collision effect
    public GameObject CollisionEffect;

    public GameObject Box;
    public GameObject Light;

    private BoxCollider Box_Collider;

    // Use this for initialization
    void Start () {
        Box_Collider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Light.SetActive(false);
            Box.SetActive(false);

            //play sound
            Sound.playSound("Coin Sound");

            //for the collision effect
            CollisionEffect.SetActive(true);

            Box_Collider.enabled = false;
        }
    }
}
