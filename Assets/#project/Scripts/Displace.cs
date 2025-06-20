using UnityEngine;

public class Displace : MonoBehaviour
{
    [SerializeField] protected Vector3 destination;
    [SerializeField] protected float time = 2f;
    protected Vector3 startPosition;
    protected float chrono;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        chrono += Time.deltaTime;
        Move();
    }

    protected virtual void Move()
    {
        transform.position = Vector3.Lerp(startPosition, destination, chrono / time);
    }
}
