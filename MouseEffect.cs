using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEffect : MonoBehaviour
{
    public GameObject circlePrefab;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mPosition.z = 0;
            Instantiate(circlePrefab, mPosition, Quaternion.identity);
        }
    }

}
