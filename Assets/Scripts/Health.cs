using System;
using UnityEngine;

public class Health
{
    public Action OnHealthZero;
    private float healthPoints;

    public float GetHealthPoints()
    {
        return healthPoints;
    }

    public void IncreaseHealth(float toIncrease)
    {
        healthPoints += toIncrease;
    }

    public void DecreaseHealth(float toDecrease)
    {
        healthPoints -= toDecrease;
        Debug.Log(healthPoints);


        if(GetHealthPoints() <= 0)
        {
            OnHealthZero?.Invoke();
        }
    }


    public Health(float initialHealth)
    {
        healthPoints = initialHealth;
    }

}
