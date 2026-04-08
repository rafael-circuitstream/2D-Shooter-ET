using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Enemy> allSpawnedEnemies;

    [SerializeField] private Enemy[] possibleEnemyPrefabs;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 2f, 3f);

    }

    private void SpawnRandomEnemy()
    {
        int amountOfIndexes = possibleEnemyPrefabs.Length;

        int randomIndex = Random.Range(0, amountOfIndexes);

        Instantiate(possibleEnemyPrefabs[randomIndex]);
    }

    private void Update()
    {

    }

}


















/*
private Weapon weaponOption1;
private Weapon weaponOption2;
*/


/*
weaponOption1 = new RangedWeapon( newFireRate:5.5f , newDamage:10 ) ;
weaponOption2 = new MeleeWeapon();


FindAnyObjectByType<Player>().EquipWeapon(weaponOption1);
*/




/*

if(Input.GetKeyDown(KeyCode.Alpha1))
{
    FindAnyObjectByType<Player>().EquipWeapon(weaponOption1);
}
else if(Input.GetKeyDown(KeyCode.Alpha2))
{
    FindAnyObjectByType<Player>().EquipWeapon(weaponOption2);
}

*/