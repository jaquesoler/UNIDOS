using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundEntity : MonoBehaviour
{
    public Vector2 Velocity = new Vector2(1, 0);

    [Range(0, 5)]
    public float RotateSpeed = 1f;
    [Range(0, 5)]
    public float Radius = 10f;

    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        _centre = GameObject.FindGameObjectWithTag("Ent").transform.position;
    }

    private void Update()
    {
        _centre += Velocity * Time.deltaTime;

        _angle += RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;

        transform.position = _centre + offset;
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawSphere(_centre, 0.1f);
        Gizmos.DrawLine(_centre, transform.position);
    }
}
