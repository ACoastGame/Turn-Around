using UnityEngine;
using DG.Tweening;

public class CharacterMovement_After : MonoBehaviour {

    public GameObject[] waypoints;

    int current = 0;

    float speed = 3f;

    float WPradius = 1.8f;

    public Animator _animator;

    float KillDelay = 1f;

    private CharacterMovement_After AfterMovement;
    private BoxCollider BXColliderr;

    public GameObject ParticlesEffect;

    // Use this for initialization
    void Start()
    {
        AfterMovement = GetComponent<CharacterMovement_After>();
        BXColliderr = GetComponent<BoxCollider>();

        _animator.SetBool("Run", true);
    }

    private void Update()
    {

        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        _animator.SetBool("Run", true);

        //to look at the direction its moving to
        transform.LookAt(waypoints[current].transform.position);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);

            //play sound
            Sound.playSound("Player");

            //for the player Retry UI
            FindObjectOfType<GameManager>().Playerdead();

            ParticlesEffect.SetActive(true);

            //Shake the camera for 1 second after collision with player
            Camera.main.transform
                .DOShakePosition(0.5f, .2f, 20, 90f)
                .OnComplete(() =>
                {
                    //What happens after shaking complete

                });
        }

        if (other.gameObject.CompareTag("Kill Other"))
        {
            _animator.SetTrigger("Attack");
        } 
    }
 }