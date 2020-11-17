using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    public float totalTime = 20;
    public Movement1 green;
    public Movement2 red;
    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        if(totalTime<=0)
        {
            if (((green.loc1.y <= 1.42 && green.loc1.y >= 1.41) && (green.loc1.x <= 0.9 && green.loc1.x >= -0.7)) && ((red.loc2.y <= 1.42 && red.loc2.y >= 1.41) && (red.loc2.x <= 0.9 && red.loc2.x >= -0.7)))
                SceneManager.LoadScene("Tie");
            else if ((green.loc1.y <= 1.42 && green.loc1.y >= 1.41) && (green.loc1.x <= 0.9 && green.loc1.x >= -0.7))
                SceneManager.LoadScene("GreenWin");
            else if ((red.loc2.y <= 1.42 && red.loc2.y >= 1.41) && (red.loc2.x <= 0.9 && red.loc2.x >= -0.7))
                SceneManager.LoadScene("RedWin");
            else
                SceneManager.LoadScene("BothLose");
        }
    }
}
