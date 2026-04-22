using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.CompareTag("Player"))
        {
            Character temporaryCharacter = collision.attachedRigidbody.GetComponent<Character>();
            CollectPickUp(temporaryCharacter);
        }

    }


    protected virtual void CollectPickUp(Character receiver)
    {
        //Play sound
        //Spawn an effect
        Destroy(gameObject);
    }
}
