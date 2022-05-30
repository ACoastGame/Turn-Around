using UnityEngine;
using DG.Tweening;

public class EnemyScript : MonoBehaviour {

	public GameObject ParticlesEffect;

	public Animator _animator;

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

			//_animator.SetTrigger("death");

			//Shake the camera for 1 second after collision with player
			Camera.main.transform
				.DOShakePosition(0.5f, .2f, 20, 90f)
				.OnComplete(() =>
				{
					//What happens after shaking complete

				});
		}
	}
}
