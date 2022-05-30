using UnityEngine;
using System.Linq;

public class PlayerControler : MonoBehaviour {

    float moveSpeed = 2f;

    public Animator _animator;

    public GameObject ParticlesEffect;
    public GameObject ParticlesEffect2;
    public GameObject AddOneUI;
    public GameObject EnemyParticlesEffect1;
    public GameObject EnemyParticlesEffect2;
    public GameObject EnemyParticlesEffect3;
    public GameObject EnemyParticlesEffect4;
    public GameObject EnemyParticlesEffect5;
    public GameObject EnemyParticlesEffect6;

    float Multiplier = 1.05f;
    float Deductor = 0.9f;

    Vector3 velocity;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update ()
	{
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        velocity = direction * moveSpeed;

        // Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * 0.9f);

         if (velocity != Vector3.zero)
         {
             _animator.enabled = true;

             transform.rotation = Quaternion.LookRotation(velocity);
             transform.Translate(velocity * moveSpeed * Time.deltaTime, Space.World);

             transform.position = new Vector3( Mathf.Clamp(transform.position.x, -39f, 57f), transform.position.y, Mathf.Clamp(transform.position.z, -21f, 73f));
         }

         else
         {
             _animator.enabled = false;
         } 
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
           AddOneUI.SetActive(true);

            //to increase the player size
            gameObject.transform.localScale *= Multiplier;

            //change the move speed
            moveSpeed = 2f;
        }

        if (other.gameObject.CompareTag("enemy1"))
        {
            //for the point collection
            Destroy(other.gameObject);

            //to increase the player size
            gameObject.transform.localScale *= Deductor;

            //change the move speed
            moveSpeed = 3f;

            //play sound
            Sound.playSound("Hit Sound 1");

            EnemyParticlesEffect1.SetActive(true);
        }

        if (other.gameObject.CompareTag("enemy2"))
        {
            //for the point collection
            Destroy(other.gameObject);

            //to increase the player size
            gameObject.transform.localScale *= Deductor;

            //change the move speed
            moveSpeed = 3f;

            //play sound
            Sound.playSound("Hit Sound 1");

            EnemyParticlesEffect2.SetActive(true);
        }

        if (other.gameObject.CompareTag("enemy3"))
        {
            //for the point collection
            Destroy(other.gameObject);

            //to increase the player size
            gameObject.transform.localScale *= Deductor;

            //change the move speed
            moveSpeed = 3f;

            //play sound
            Sound.playSound("Hit Sound 2");

            EnemyParticlesEffect3.SetActive(true);
        }

        if (other.gameObject.CompareTag("enemy4"))
        {
            //for the point collection
            Destroy(other.gameObject);

            //to increase the player size
            gameObject.transform.localScale *= Deductor;

            //change the move speed
            moveSpeed = 3f;

            //play sound
            Sound.playSound("Hit Sound 2");

            EnemyParticlesEffect4.SetActive(true);
        }

        if (other.gameObject.CompareTag("enemy5"))
        {
            //for the point collection
            Destroy(other.gameObject);

            //to increase the player size
            gameObject.transform.localScale *= Deductor;

            //change the move speed
            moveSpeed = 3f;

            //play sound
            Sound.playSound("Hit Sound 3");

            EnemyParticlesEffect5.SetActive(true);
        }

        if (other.gameObject.CompareTag("enemy6"))
        {
            //for the point collection
            Destroy(other.gameObject);

            //to increase the player size
            gameObject.transform.localScale *= Deductor;

            //change the move speed
            moveSpeed = 3f;

            //play sound
            Sound.playSound("Hit Sound 3");

            EnemyParticlesEffect6.SetActive(true);
        }
    }
}