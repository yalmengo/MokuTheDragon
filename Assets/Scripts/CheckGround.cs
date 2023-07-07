using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;
    [SerializeField]
    private Rigidbody2D playerRb;
    [SerializeField]
    public float force = 40f;

    private void OnTriggerEnter2D(Collider2D other) {
        isGrounded = true;
        if(other.GetComponent<BootCheck>()) {
            playerRb.velocity = new Vector2(playerRb.velocity.x, 0f);
            playerRb.AddForce(Vector2.up * force);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        isGrounded = false;
    }
}
