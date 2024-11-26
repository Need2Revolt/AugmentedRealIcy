using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;

    public void DecreaseHealth(float damage) {
        health -= damage;
        //Debug.Log("N2R: health = " + health);
    }
}
