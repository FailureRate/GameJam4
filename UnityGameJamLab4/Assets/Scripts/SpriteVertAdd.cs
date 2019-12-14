using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteVertAdd : MonoBehaviour
{
    public Sprite sp;
    public Vector2[] test;
    public ushort[] tireangle;
    // Start is called before the first frame update
    void Start()
    {
        sp.OverrideGeometry(test, tireangle);
        for (int i = 0; i < sp.triangles.Length; i++) {
            Debug.Log(sp.triangles[i]);
            
        }
        for (int i = 0; i < sp.vertices.Length; i++)
        {
            Debug.Log(sp.vertices[i]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
