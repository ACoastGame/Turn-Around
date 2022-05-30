using UnityEngine;

public class destroy_script : MonoBehaviour {

    public float destroyTime = 0.8f;

    // Use this for initialization
    void Start () {
        Destroy(gameObject, destroyTime);
    }
}
