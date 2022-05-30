using UnityEngine;

public class Emoji : MonoBehaviour {

    public float destroyTime = 1.5f;

    //where to locate the text
    public Vector3 Offset = new Vector3(0, 1, 0);

    //randomize for text
    public Vector3 RandomizeIntensity = new Vector3(0.5f, 0, 0);

    // Use this for initialization
    void Start()
    {

        Destroy(gameObject, destroyTime);

        //for the text location
        transform.localPosition += Offset;

        //randomizing the text
        transform.localPosition += new Vector3
      ( Random.Range(-RandomizeIntensity.x, RandomizeIntensity.x),
        Random.Range(-RandomizeIntensity.y, RandomizeIntensity.y),
        Random.Range(-RandomizeIntensity.z, RandomizeIntensity.z));
    }

}
