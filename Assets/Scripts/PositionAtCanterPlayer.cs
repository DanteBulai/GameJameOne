using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAtCanterPlayer : MonoBehaviour
{
    [SerializeField] private float _radios;
    [SerializeField] private float _angleSpeed;
    [SerializeField] private float _angle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vectorSpeed = Input.GetAxis("Horizontal") * _angleSpeed * Time.deltaTime;
        float posX = Mathf.Cos(_angle) * _radios;
        float posY = Mathf.Sin(_angle) * _radios;
        transform.position = new Vector3(posX, posY, 0f);
        _angle = _angle + vectorSpeed;
        
    }
}
