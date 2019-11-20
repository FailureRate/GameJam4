using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRigidBodyEvents : MonoBehaviour
{
    [SerializeField]
    [Header("RigidBody2d")]
    protected Rigidbody2D rb;
    
    private ContactFilter2D filter;
    private RaycastHit2D[] hits = new RaycastHit2D[1];
    // Start is called before the first frame update
    void Start()
    {
        
        //filter.SetLayerMask(LayerMask.GetMask("Ground"));
      // filter.SetLayerMask(LayerMask.GetMask("Player1"));
    }
    // Update is called once per frame

}
