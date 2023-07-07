using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AllGemsCollected();
    }

    public void AllGemsCollected()
    {
        if(transform.childCount == 0) {
            Debug.Log("Level Cleared");
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0) {
            SceneManager.LoadScene(1);
        } else {
            Debug.Log("Ganaste");
        }
    }
}
