using UnityEngine;

[CreateAssetMenu(menuName = "New Weapon")]
public class RangedWeapon : Weapon
{
    [SerializeField] private Projectile projectilePrefab;
    //[SerializeField] private Transform weaponTip;
    [SerializeField] private float fireRate;
   
    public override void Use(Transform tip)
    {
        Projectile clonedProjectile = GameObject.Instantiate(projectilePrefab, tip.position, tip.rotation);
        clonedProjectile.damage = damage;
    }

    public float GetFireRate()
    {
        return fireRate;
    }

    //public RangedWeapon(float newFireRate, float newDamage, Projectile newProjectile, Transform newTip)
    //{
    //    projectilePrefab = newProjectile;
    //    weaponTip = newTip;
    //    fireRate = newFireRate;
    //    damage = newDamage;
    //}
}
