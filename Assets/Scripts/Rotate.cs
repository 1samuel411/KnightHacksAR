using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed;
    public bool rotate;

    private void Awake()
    {
        
    }

    void Start()
    {

    }

    void Update()
    {
        if (rotate == false)
            return;

        Vector3 rot = transform.eulerAngles;
        rot.y += speed * Time.deltaTime;
        transform.eulerAngles = rot;
    }
}
