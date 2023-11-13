using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private bool _isMove;

    private void Update()
    {
        if (_isMove)
        {
           transform.Translate(_direction * _speed * Time.deltaTime);
        }
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
        _isMove = true;
    }
}
