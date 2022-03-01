using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    public Text health;
    public Text Food;

    public void UpdateHealthText(float health)
    {
       this.health.text = "Health :" + health;
    }
    public void UpdateFoodText(float Food)
    {
       this.Food.text = "Food :" + Food;
    }
}
