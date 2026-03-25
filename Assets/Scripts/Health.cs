using UnityEngine;

public class Health
{
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
    }


    public Health(float initialHealth)
    {
        healthPoints = initialHealth;
    }

}
