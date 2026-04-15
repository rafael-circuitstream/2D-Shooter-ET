using UnityEngine;

public class MeleeWeapon : Weapon
{
    [SerializeField] private float range;

    public override void Use(Transform tip)
    {
        Debug.Log("Slash");
    }
}
