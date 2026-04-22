using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Header("Spawning Enemies")]
    [SerializeField] private List<Enemy> allSpawnedEnemies;
    [SerializeField] private Enemy[] possibleEnemyPrefabs;
    [SerializeField] private Transform[] possibleSpawnPoints;
    [SerializeField] private Transform enemiesParent;
    
    [Space(10)]

    [Header("Score")]
    [SerializeField] private int currentScore;
    [Space(10)]

    [Header("Pick ups")]
    [SerializeField] private Pickup[] pickupsToSpawn;
    [SerializeField] private float chanceToSpawnPickup;

    private void SpawnRandomPickup(Vector2 positionToSpawn)
    {
        int randomIndex = Random.Range(0, pickupsToSpawn.Length);
        Pickup randomPickup = pickupsToSpawn[randomIndex];

        Instantiate(randomPickup, positionToSpawn, Quaternion.identity);
    }

    public void EnemyKilled(Enemy deadEnemy)
    {
        allSpawnedEnemies.Remove(deadEnemy);
        currentScore += 10;

        if (Random.Range(0, 100) < chanceToSpawnPickup)
        {
            SpawnRandomPickup(deadEnemy.transform.position);

        }

        
        //increase score
        //play sound
    }

    void Start()
    {
        StartCoroutine(  SpawnRandomEnemy()  );

    }

    private IEnumerator SpawnRandomEnemy()
    {
        while(true)
        {
            if (allSpawnedEnemies.Count < 11)
            {
                int amountOfIndexes = possibleEnemyPrefabs.Length;
                int randomIndex = Random.Range(0, amountOfIndexes);
                Enemy clonedEnemy = Instantiate(possibleEnemyPrefabs[randomIndex]);

                allSpawnedEnemies.Add(clonedEnemy);

                int amountOfSpawnPoints = possibleSpawnPoints.Length;
                int randomIndexOfSpawnPoint = Random.Range(0, amountOfSpawnPoints);
                Transform randomSpawnPoint = possibleSpawnPoints[randomIndexOfSpawnPoint];

                clonedEnemy.transform.SetParent(enemiesParent);
                clonedEnemy.transform.position = randomSpawnPoint.position;

            }

            yield return new WaitForSeconds(1f);
        }
        
    }

    private void Update()
    {

    }



    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void RegisterHighScore()
    {
        if(currentScore > PlayerPrefs.GetInt("HighestScore"))
        {
            PlayerPrefs.SetInt("HighestScore", currentScore);
        }



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