using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("yolo");
        transform.localScale = new Vector3(3,3,3);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = new Vector3(0.3f, 0.3f, 0.3f);
        transform.Rotate(rot);
    }
}