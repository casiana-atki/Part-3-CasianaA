using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMonster : MonsterBase
{
    protected float speed = 1f;
    protected float minX = 12f;
    protected float maxX = 26f;
    protected bool movingRight = true;


    protected override void Update()
    {

        base.Update();
        growthdiv = 10f; 
        float movementAmount = speed * Time.deltaTime;
        float direction = movingRight ? 1f : -1f;
        Vector3 newPosition = transform.position + new Vector3(movementAmount * direction, 0f, 0f);
        if (newPosition.x >= maxX)
        {
            movingRight = false;
        }
        else if (newPosition.x <= minX)
        {
            movingRight = true;
        }
        transform.position = newPosition;
    }
}
