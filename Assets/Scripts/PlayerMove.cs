using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _radios;
    [SerializeField] private float _speedLerp;
    [SerializeField] private float _angleSpeed;
    [SerializeField] private float _angle;

    void Update()
    {
        float vectorSpeed = Input.GetAxis("Horizontal") * _angleSpeed * Time.deltaTime;
        float posX = Mathf.Cos(_angle) * _radios;
        float posY = Mathf.Sin(_angle) * _radios;
        transform.position = Vector3.Lerp(transform.position, new Vector3(posX, posY, 0f), Time.deltaTime * _speedLerp); 
        _angle = _angle + vectorSpeed;

    }
}
