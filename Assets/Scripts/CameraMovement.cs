using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x , Mathf.Clamp(player.position.y, 7f, 7f), player.position.z - 11f);
    }
}
