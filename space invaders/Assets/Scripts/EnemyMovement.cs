using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float MoveAmount;
    int CurrentLane = 0;
    int CurrentRow = 0;
    int MoveDir;
    float TimeToMove = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MoveDir = 1;
    }
    private void Update()
    {
        if (TimeToMove <= 0)
        {
            rb.MovePosition(new(transform.position.x + MoveAmount * MoveDir, transform.position.y));
            if (CurrentRow >= 12)
            {
                rb.MovePosition(new(transform.position.x, transform.position.y - 1.5f));
                if (MoveDir == 1){ MoveDir = -1; }
                else MoveDir = 1;
                CurrentRow = 0;
                CurrentLane += 1;
            }
            if (CurrentLane >= 4)
            {
                //Temporary
                Destroy(gameObject);
            }
            else
                CurrentRow += 1;
            TimeToMove = 1;
        }
        else
            TimeToMove -= 1 * Time.deltaTime;
    }
}

