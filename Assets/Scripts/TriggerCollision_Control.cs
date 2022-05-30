using UnityEngine;

public class TriggerCollision_Control : MonoBehaviour {

	public GameObject Emoji;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Character"))
		{
			//play sound
			Sound.playSound("Player");

			ShowEmoji();
		}
	}

	public void ShowEmoji()
	{

		Transform Shownumber = Emoji.transform;
		Instantiate(Emoji, transform.position, Shownumber.rotation);
	}
}
