using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    int numberOfBounce = 0;

    AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Plane")
        {
            numberOfBounce++;
            AudioSource.Play();

            if (numberOfBounce == 3)
                SceneManager.LoadScene("Level_3");
        }        
    }
}
