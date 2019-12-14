using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public string levelName;
    public GameObject goal1;
    public GameObject goal2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goal1.GetComponent<Goal>().fire && goal2.GetComponent<Goal>().fire)
        {
            SceneManager.LoadScene(levelName, LoadSceneMode.Single);
        }
    }
}
