using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootCheck : MonoBehaviour
{

   public AudioSource stompSound;
   private void OnTriggerEnter2D(Collider2D other) {
    if(other.GetComponent<CheckGround>()) {
        transform.parent.GetComponent<SpriteRenderer>().enabled = false;
        Destroy(transform.parent.gameObject, 0.5f);
        stompSound.Play();
    }
   }
}
