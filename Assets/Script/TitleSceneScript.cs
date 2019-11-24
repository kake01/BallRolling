using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleSceneScript : MonoBehaviour
{
    public static int floorspeed;
    public static int ballspeed;

    public void ChangeSpeed(int initfloorspeed, int initballspeed)
    {
        floorspeed = initfloorspeed;
        ballspeed = initballspeed;
        Debug.Log(floorspeed + "::" + ballspeed);
    }

    public void ChangeScene() => SceneManager.LoadScene("Main");

    public static int GetFloorSpeed()
    {
        return floorspeed;
    }

    public static int GetBallSpeed() => ballspeed;
}