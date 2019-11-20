using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyEvents : MonoBehaviour
{
    [SerializeField]
    [Header("RigidBody")]
     Rigidbody2D rb;
    [SerializeField]
    [Header("BoxCollider2D")]
    private BoxCollider2D box;
    [SerializeField]
    [Header("ContactNames")]
    private string[] names;
    [SerializeField]
    [Header("Speeds")]
    private float[] speeds;


    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
    }

    public void MoveLeft()
    {
        
        rb.AddForce(new Vector2(-0.2f, 0), ForceMode2D.Impulse);
        if (rb.velocity.x < -6) { rb.velocity = new Vector2(-6, rb.velocity.y); }
    }
    public void MoveRight()
    {
        rb.AddForce(new Vector2(0.2f, 0), ForceMode2D.Impulse);
        if (rb.velocity.x > 6) { rb.velocity = new Vector2(6, rb.velocity.y); }
    }
    public void ZeroStop()
    {
        rb.velocity = new Vector2(0.0f, rb.velocity.y);
    }
    public void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(new Vector2(0.0f, 6.0f), ForceMode2D.Impulse);
        }
    }
    private bool IsGrounded()
    {
        foreach (string name in names)
        {
            if (box.IsTouchingLayers(LayerMask.GetMask(name)))
            {
                return true;
            }
        }
        return false;
    }
}
