using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
    public Movement1 player1;
    public Movement2 player2;
    float pos1;
    float pos2;
    float y1, y2;
    // Update is called once per frame
    void Update()
    {
        pos1 = player1.loc1.x;
        pos2 = player2.loc2.x;
        y1 = player1.loc1.y;
        y2 = player2.loc2.y;
        //print(Mathf.Abs(y1 - y2));
        if(Input.GetButtonDown("attack1"))
        {
            if ((Mathf.Abs(pos1 - pos2) <= 1) && !player2.crouch && (Mathf.Abs(y1 - y2)) < 0.3)
            {
                player2.rb2.AddForce(new Vector2(((pos2 - pos1) / Mathf.Abs(pos2 - pos1)) * 3000f, 200f));
            }
        }
        if (Input.GetButtonDown("attack2"))
        {
            if ((Mathf.Abs(pos1 - pos2) <= 1) && !player1.crouch && (Mathf.Abs(y1 - y2)) < 0.3)
            {
                player1.rb.AddForce(new Vector2(((pos1 - pos2) / Mathf.Abs(pos1 - pos2)) * 3000f, 200f));
            }
        }
    }
}
