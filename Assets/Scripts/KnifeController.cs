using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    [SerializeField] public float runSpeed;
    private Rigidbody2D _rigidbody2D;
    private bool _trigger = false;
    private Transform _transform;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GameObject.Find("Ground").GetComponent<Transform>();
    }

    void Update()
    {
        if (!_trigger)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody2D.AddForce(new Vector2(0, runSpeed));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "Ground")
        {
            transform.SetParent(_transform);
            _rigidbody2D.totalForce = Vector2.zero;
            _trigger = true;
        }
    }
}
