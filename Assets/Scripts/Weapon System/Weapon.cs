using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    [SerializeField] protected float damage;

    public abstract void Use(Transform tip);

    public float GetDamageValue()
    {
        return damage;
    }

}
