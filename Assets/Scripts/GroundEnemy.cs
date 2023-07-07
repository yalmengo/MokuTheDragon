using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    public Rigidbody2D rgbd;
    // BoxCollider2D boxCollider;
    void Start()
    {
        // rgbd = GetComponent<Rigidbody2D>();
        // boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isFacingRight()) {
            rgbd.velocity = new Vector2(moveSpeed, 0f);
        } else {
            rgbd.velocity = new Vector2(-moveSpeed, 0f);
        }
    }

    private bool isFacingRight() {
        return transform.parent.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D other) {
        transform.parent.localScale = new Vector2(-(Mathf.Sign(rgbd.velocity.x)), transform.parent.localScale.y);
    }
}
