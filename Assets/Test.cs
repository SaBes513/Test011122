using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float Distance, Speed;
    Vector3 Pos = Vector3.zero; 

    // Update is called once per frame
    void Update()
    {
        Pos.z += Speed * Time.deltaTime;
        if (Pos.z > Distance) Destroy(gameObject);
        else
            transform.position = Pos;
    }
}
