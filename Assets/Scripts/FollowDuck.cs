using UnityEngine;

public class FollowDuck : MonoBehaviour
{
    GameObject Player;

    float Back = 1.02f;
    public Animator _animator;

    public GameObject ParticlesEffect;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        transform.position = Player.gameObject.transform.position * Back;

    }

}
