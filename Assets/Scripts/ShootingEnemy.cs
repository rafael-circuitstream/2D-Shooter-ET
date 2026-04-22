using UnityEngine;

public class ShootingEnemy : Enemy
{
    [SerializeField] private Weapon currentWeapon;
    [SerializeField] private Transform weaponTip;
    private bool canShoot;

    public override void Attack()
    {
        if(canShoot)
        {
            currentWeapon.Use(weaponTip);
            canShoot = false;
            Invoke("CanShootAgain", 1.5f);
            base.Attack();
        }

    }

    private void CanShootAgain()
    {
        canShoot = true;
    }

    protected override void Start()
    {
        canShoot = true;
        base.Start();
    }

}
