using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        // Method 1
        var movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        // Method 2
        var xMovement = 0f;
        var zMovement = 0f;

        if (Input.GetKey(KeyCode.RightArrow)) {
            xMovement += 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            xMovement -= 1f;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            zMovement += 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            zMovement -= 1f;
        }

        transform.position += new Vector3(movement.x, 0f, movement.y) * speed * Time.deltaTime;
    }
}
