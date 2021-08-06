﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEftOff : MonoBehaviour
{
    float time;
    public float _fadeTime = 0.2f;
 
    
    void Update()
    {
        if (time < _fadeTime)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f - time / _fadeTime);

        }
        else
        {
            time = 0;
            this.gameObject.SetActive(false);
            Destroy(this.gameObject, time);
        }
        time += Time.deltaTime;
       
    }

    public void resetAnim()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        this.gameObject.SetActive(true);
    }
}
