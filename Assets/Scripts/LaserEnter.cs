using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnter : MonoBehaviour
{
    public GameObject _laser;
    public float _timerToShot = 10;
    public float _timerShot = 3;
    private bool canShot;
    private void Start()
    {
        _laser.SetActive(false);
    }
    void Update()
    {
        if (_timerToShot <= 0)
        {
            if (canShot)
            {
                Shot();
                canShot = false;
            }
            if (_timerShot <= 0)
            {
                _timerToShot = 10;
                _timerShot = 3;
            }
            _timerShot -= Time.deltaTime;
        }
        else
        {
            canShot = true;
            _laser.SetActive(false);
            transform.localScale = new Vector3(1f, 2f, 1f);
            _timerToShot -= Time.deltaTime;
        }
    }
   
    private void Shot()
    {
        float x = Random.Range(-20, 20);
        float y = Random.Range(-20, 20);
        gameObject.transform.rotation = Quaternion.LookRotation(new Vector3(x, y, 0f));
        _laser.SetActive(true);
        transform.localScale = new Vector3(1f,20f,1f);
    }
}
