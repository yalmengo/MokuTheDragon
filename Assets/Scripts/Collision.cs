using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
    if(other.CompareTag("Player")) {
        // Destroy(other.gameObject.getParent, 0.3f);
    }
   }
}
