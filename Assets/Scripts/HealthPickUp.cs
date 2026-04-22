using UnityEngine;

public class HealthPickUp : Pickup
{
    [SerializeField] private float amountOfHealth;

    protected override void CollectPickUp(Character receiver)
    {
        //heal the player
        receiver.healthModule.IncreaseHealth(amountOfHealth);
        base.CollectPickUp(receiver); //Destroy();
    }
}
