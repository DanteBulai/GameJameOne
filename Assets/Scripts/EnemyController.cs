using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static Action<int> DestrouEnemy;
    [SerializeField] private int numberEnemy = 1;
    [SerializeField] private List<Material> listMaterials;
    private Rigidbody _rigidbody;
    private Renderer _renderer;
    public float powerForceToCenter = 10;
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();
        _rigidbody = GetComponent<Rigidbody>();
        SetMaterial(numberEnemy);
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(-transform.position * powerForceToCenter);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (numberEnemy == 0)
            {
                DestroyEnemy();
            }
            else
            {

                SetMaterial(--numberEnemy);
            }
        }
    }
    public void DestroyEnemy()
    {
        DestrouEnemy?.Invoke(0);
        Destroy(gameObject);
    }
    private void SetMaterial(int i)
    {
        if (listMaterials[i])
        {
            _renderer.material = listMaterials[i];
        }
    }
}
