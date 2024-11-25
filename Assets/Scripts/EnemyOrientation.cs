using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrientation : MonoBehaviour
{
    public GameObject projectile;
    private Transform camera;
    private float speed = 250;
    private int axis = 0;
    private float timer;
    private float delay = 1.5f;
    private float launchVelocity = 100f;

    private bool alreadyShot = false;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > delay) {
            axis++;
            axis = axis%4;
            timer = 0;
            alreadyShot = false;
        }
        
        switch(axis){
            case 0:
                transform.Rotate(speed * Time.deltaTime, 0, 0);
            break;
            case 1:
                transform.Rotate(0, speed * Time.deltaTime, 0);
            break;
            case 2:
                transform.Rotate(0, 0, speed * Time.deltaTime);
            break;
            case 3:
                transform.LookAt(camera);
                if(!alreadyShot) {
                    alreadyShot = true;
                    Shoot();
                }
            break;

            default:
                transform.LookAt(camera);
            break;
        }
    }

    void Shoot() {
        GameObject round = Instantiate(projectile, transform.position, transform.rotation);
        round.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
    }
}
