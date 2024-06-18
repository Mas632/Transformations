using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationObject : MonoBehaviour
{
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected float _rotateSpeed;
    [SerializeField] protected float _resizeSpeed;
    [SerializeField] protected float _minSize;
    [SerializeField] protected float _maxSize;

    private void Update()
    {
        Move();
        Rotate();
        Resize();

        if (ShouldChangeResizeSpeedDirection())
        {
            ChangeSpeedResizeDirection();
        }
    }

    protected void Move()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }

    protected void Rotate()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }

    protected void Resize()
    {
        transform.localScale += _resizeSpeed * Vector3.one * Time.deltaTime;
    }

    protected void ChangeSpeedResizeDirection()
    {
        _resizeSpeed *= -1;
    }

    protected bool ShouldChangeResizeSpeedDirection()
    {
        return (_resizeSpeed > 0 && transform.localScale.x > _maxSize) || (_resizeSpeed < 0 && transform.localScale.x < _minSize);
    }
}
