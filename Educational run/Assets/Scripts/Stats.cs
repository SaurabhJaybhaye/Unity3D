using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public float health;
    public float Food;

   
    // Update is called once per frame
    public void UpdateHealth(float value)
    {
        health -= value;
    }

    public void UpdateFood(float value)
    {
        Food += value;
    }
}
