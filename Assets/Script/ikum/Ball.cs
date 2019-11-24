using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public int floorspeed;
    public int ballspeed;


    private void Start()
    {
        floorspeed = TitleSceneScript.GetFloorSpeed();
        ballspeed = TitleSceneScript.GetBallSpeed();
        Debug.Log("floorspeed" + floorspeed);
        Debug.Log("ballspeed" + ballspeed);
    }


    void Update()
    {
        //ボールが一定以上下に落ちたらゲームオーバーにする
        if (this.transform.position.y < -10)
            SceneManager.LoadScene("GameOver");

        //ステージを動かす
        transform.Translate(0, 0, floorspeed * Time.deltaTime);

        //左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-ballspeed * Time.deltaTime, 0, 0);
        }
        //右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(ballspeed * Time.deltaTime, 0, 0);
        }
    }
}
