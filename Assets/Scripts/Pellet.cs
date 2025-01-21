
using UnityEngine;

public class Pellet : MonoBehaviour
{

    public int points = 10;
    // you can access this same method to powerpellets wiht protected virtual void code, "Eat"
   protected virtual void Eat()
    {
        FindObjectOfType<GameManager>().PelletEaten(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            Eat();
        }
    }
}
