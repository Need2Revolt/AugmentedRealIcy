using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrientation : MonoBehaviour
{
    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera);
    }
}
