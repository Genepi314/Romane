using UnityEngine;

public class BackAndForth : Displace
{
    protected override void Move()
    {
        base.Move();
        if (chrono >= time)
        {
            chrono = 0f;
            //Version longue:
            Vector3 temp = startPosition;
            startPosition = destination;
            destination = temp;
            //Version courte:
            //(destination, startPosition) = (startPosition, destination);
        }
    }

}
