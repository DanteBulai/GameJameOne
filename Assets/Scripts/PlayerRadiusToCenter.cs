using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRadiusToCenter : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _powerForce = 0.1f;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float distanse = Vector3.Distance(Vector3.zero, transform.position);
        int up = 0;
        if (distanse > _radius) up = 1;
        else up = -1;
        Vector3 force = transform.forward * _powerForce * up;
        _rigidbody.AddForce(force);

    }
}
