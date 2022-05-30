using UnityEngine;

public class diactivate : MonoBehaviour {

    public float DeactivateDelay = 0.7f;

    // Use this for initialization
    void Start () {
        Invoke("Deactivate", DeactivateDelay);
    }

    public void Deactivate()
    {
        Invoke("Deactivate", DeactivateDelay);

        gameObject.SetActive(false);
    }
}
