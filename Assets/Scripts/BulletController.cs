using System;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public static Action<int> Put;
    [SerializeField] private float _speedMove;
    [SerializeField] private Vector3 _startVector;

    [SerializeField] private Vector3 toMove;
    private Rigidbody _rigidbody;
    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        toMove = new Vector3(0, 0, 0) + _startVector;
    }
    private void FixedUpdate()
    {
       // _rigidbody.AddForce(toMove, ForceMode.Acceleration);
        _rigidbody.velocity = toMove * _speedMove;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 move = new Vector3(0, 0, 0);
        if (collision.gameObject.tag.Equals("Player"))
        {
            float power = collision.gameObject.GetComponent<PlayerPower>().GetPower();
            move -= collision.gameObject.transform.position.normalized * power;
            Put?.Invoke(2);
        } else move = collision.gameObject.transform.position.normalized;
        toMove = move;     
    }
}
