using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Character randomCharacter;
    [SerializeField] private Player mainPlayer;
    [SerializeField] private Enemy randomEnemy;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(randomCharacter.GetComponent<IDash>() != null)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
