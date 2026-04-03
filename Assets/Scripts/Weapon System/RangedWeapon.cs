using UnityEngine;

public class RangedWeapon : Weapon
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float fireRate;
   
    public override void Use()
    {
        Debug.Log("Pew pew");
    }

    public float GetFireRate()
    {
        return fireRate;
    }

    public RangedWeapon(float newFireRate, float newDamage)
    {
        fireRate = newFireRate;
        damage = newDamage;
        
    }
}
