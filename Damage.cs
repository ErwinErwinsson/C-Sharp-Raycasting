using UnityEngine;

public class Damage : MonoBehaviour
{
    // Assigning the health of the object to 100.
    int health = 100;

    // A method to take damage from othe Objects by passing in the amount of damage.
    public void TakeDamage(int damage)
    {
        // Damaging the GameObject.
        health -= damage;
        print(health); // Printing out the health for debugging purposes.

        // If health is 0 or less then we destroy the gameObject.
        // You can put you death animation here or whatever.
        if (health <= 0)
            Destroy(transform.gameObject);
    }
}
