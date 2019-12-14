using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    [Header("GameObject Tag")]
    private string gmTag;
    [SerializeField]
    [Header("Fire")]
    public bool fire;

    // Start is called before the first frame update
    void Start()
    {
        fire = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(gmTag))
        {
            fire = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(gmTag))
        {
            fire = false;
        }
    }
    public bool GetFire()
    {
        return fire;
    }
}
