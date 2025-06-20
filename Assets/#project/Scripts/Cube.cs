using UnityEngine;

public class Cube : MonoBehaviour, ICollision
{
    public void WhenCollision()
    {
        //Ici, on DETRUIT le gameObject, c'est-à-dire lui-même. Il disparaît de la mémoire! Pas la méthode idéale pour un jeu en vrai.
        Destroy(gameObject);
    }
}
