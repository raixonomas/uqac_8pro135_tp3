using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LoadNextLevel());
    }
    
    // Load the next level
    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(time);
        
        SceneManager.LoadScene("Menu");
    }
}
