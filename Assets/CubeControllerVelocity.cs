using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControllerVelocity : MonoBehaviour
{
    [SerializeField] float acceleration;

    Vector3 velocity = Vector3.zero;

    void Update()
    {
        // Method 1
        var movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        // Set velocity based on movement
        //velocity += .....

        // Set position based on velocity
        //transform.position += .....
    }
}
