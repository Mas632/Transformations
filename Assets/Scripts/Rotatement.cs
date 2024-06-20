using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Rotate();
    }

    protected void Rotate()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}
