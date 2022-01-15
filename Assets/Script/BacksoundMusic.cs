using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacksoundMusic : MonoBehaviour
{

    private static BacksoundMusic backgroundMusic;

    private void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
