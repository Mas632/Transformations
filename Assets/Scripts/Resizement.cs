using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Resizement : MonoBehaviour
{
    [SerializeField] private float _minSize = 0.2f;
    [SerializeField] private float _maxSize = 0.75f;
    [SerializeField] private float _speed = 0.1f;

    private void Update()
    {
        Resize();
        
        if (ShouldChangeResizeSpeedDirection())
        {
            ChangeSpeedResizeDirection();
        }
    }

    protected void Resize()
    {
        transform.localScale += _speed * Vector3.one * Time.deltaTime;
    }

    protected void ChangeSpeedResizeDirection()
    {
        _speed *= -1;
    }

    protected bool ShouldChangeResizeSpeedDirection()
    {
        return (_speed > 0 && transform.localScale.x > _maxSize) || (_speed < 0 && transform.localScale.x < _minSize);
    }
}
