using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioSource> SoundList;

    public void PlayNumber(int number)
    {
        SoundList[number].Play();
    }
    private void OnEnable()
    {
        EnemyController.DestrouEnemy += PlayNumber;
        PutCenter.Win += PlayNumber;
        BulletController.Put += PlayNumber;
    }
    private void OnDisable()
    {
        EnemyController.DestrouEnemy -= PlayNumber;
        PutCenter.Win -= PlayNumber;
        BulletController.Put -= PlayNumber;
    }
}
