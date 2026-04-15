using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Enemy> allSpawnedEnemies;

    [SerializeField] private Enemy[] possibleEnemyPrefabs;
    [SerializeField] private Transform[] possibleSpawnPoints;

    [SerializeField] private Transform enemiesParent;

    [SerializeField] private int currentScore;

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

    public void EnemyKilled(Enemy deadEnemy)
    {
        allSpawnedEnemies.Remove(deadEnemy);
        currentScore += 10;

        //Spawn pick up at deadEnemy.position;
        //increase score
        //play sound
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