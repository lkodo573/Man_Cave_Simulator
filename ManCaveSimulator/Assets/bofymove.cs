using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bofymove : MonoBehaviour
{
    public float rotMult = 4f;

    float yaw = 0f;
    float pitch = 0f;

    public float maxY = 0; // For some reason, the signs are strange.
    public float minY = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        yaw += rotMult * Input.GetAxis("Mouse X");
        pitch -= rotMult * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, maxY, minY); // Clamp viewing up and down

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
