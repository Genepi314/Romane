
using UnityEngine;

public class MoveAndSwell : Displace
{
    [SerializeField] private Vector3 scaleDestination;
    private Vector3 scaleStart;
    //private float Bouuuh = 1.5f;

    protected override void Start()
    {
        base.Start();
        scaleStart = transform.localScale; 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Move()
    {
        base.Move();
        //transform.localScale += Vector3.one * Bouuuh;
        transform.localScale = Vector3.Lerp(scaleStart, scaleDestination, chrono / time);
    }
}
