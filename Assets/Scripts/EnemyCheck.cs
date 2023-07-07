using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Enemy")) {
            Destroy(transform.parent.gameObject);
            transform.parent.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
