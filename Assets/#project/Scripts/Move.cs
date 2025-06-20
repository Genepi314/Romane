using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        //On ajoute le vecteur à la position en fonction de la vitesse et du temps 
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent(out ICollision coll))
        {
            coll.WhenCollision();
        }
    }
}
