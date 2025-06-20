using UnityEngine;

public class Sphere : MonoBehaviour, ICollision
{
    public void WhenCollision()
    {
        transform.localScale *= 5;
    }
}
