using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class refresh : MonoBehaviour
{
    public string levelName;
    public bool isWater;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isWater)
        {
            if (collision.CompareTag("Player1") || collision.CompareTag("Player2"))
            {
                SceneManager.LoadScene(levelName, LoadSceneMode.Single);
            }
        }
        if (isWater)
        {
            if (collision.CompareTag("Player1"))
            {
                SceneManager.LoadScene(levelName, LoadSceneMode.Single);
            }
        }
    }
}
