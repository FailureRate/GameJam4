using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRectVolume : SpawnerVolume
{
    [Header("Parameters")]
    [SerializeField, Min(0)] private float width;
    [SerializeField, Min(0)] private float height;

    public override Vector3 SpawnPoint()
    {
        Vector2 random = Random.insideUnitSphere.XY() * new Vector2(width, height) * 0.5f;
        return transform.position.XY() + random;
    }

    private void OnDrawGizmosSelected()
    {
        Vector3 upper = new Vector3(width / 2, height / 2, 0);
        Vector3 ur = transform.position + upper;
        Vector3 lr = transform.position + upper.Multiply(new Vector3(1, -1, 1));
        Vector3 ll = transform.position + upper.Multiply(new Vector3(-1, -1, 1));
        Vector3 ul = transform.position + upper.Multiply(new Vector3(-1, 1, 1));

        Color colour = Gizmos.color;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(ur, lr);
        Gizmos.DrawLine(lr, ll);
        Gizmos.DrawLine(ll, ul);
        Gizmos.DrawLine(ul, ur);
        Gizmos.color = colour;
    }
}
