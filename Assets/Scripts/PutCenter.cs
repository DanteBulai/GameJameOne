using System;
using System.Collections.Generic;
using UnityEngine;

public class PutCenter : MonoBehaviour
{
    public static Action<int> Win;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Win?.Invoke(1);
            print("Game Over");
        }
    }
}
