using UnityEngine;

public class AnimationScript : MonoBehaviour {

    public bool isAnimated = false;

    public bool isRotating = false;
    public bool isFloating = false;

    public Vector3 rotationAngle;
    public float rotationSpeed;

    public float floatSpeed;

	// Update is called once per frame
	void Update () {

        if(isAnimated)
        {
            if(isRotating)
            {
                transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
            }

            if(isFloating)
            {
                Vector3 moveDir = new Vector3(0.0f, 0.0f, floatSpeed);
                transform.Translate(moveDir);

                    floatSpeed = +floatSpeed;
            }
        }
	}
}
