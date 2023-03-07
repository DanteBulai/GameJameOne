using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{
    [SerializeField] private float _powerPin;
    public float GetPower()
    {
        return _powerPin;
    }
}
