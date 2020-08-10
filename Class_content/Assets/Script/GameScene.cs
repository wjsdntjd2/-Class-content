using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    AudioSource test;
    void Start()
    {
        if (SaveMng.Ins.Load("BGM"))
            test.Play();
        else
            test.Stop();
    }
}
