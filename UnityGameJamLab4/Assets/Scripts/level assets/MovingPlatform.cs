using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3[] pathNodes;
    [SerializeField]
    private int pathnode;
    public Rigidbody2D rb;
    private Vector3 direction;
    public float speedVar;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pathnode < pathNodes.Length)
        {
            rb.velocity = Vector2.zero;
            movetoward(pathNodes[pathnode]);
            if ((pathNodes[pathnode].x + 0.5 > transform.position.x && transform.position.x > pathNodes[pathnode].x - 0.5) && (pathNodes[pathnode].y + 0.5 > transform.position.y && transform.position.y > pathNodes[pathnode].y - 0.5))
            { pathnode++; rb.velocity = Vector2.zero; }
            if (pathnode >= pathNodes.Length) { pathnode = 0; }
        }
    }

    void movetoward(Vector3 position)
    {
        direction = position - transform.position;
        rb.velocity += new Vector2(direction.x, direction.y) * speedVar;
    }
}
