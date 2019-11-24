using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // ボールがゴールに接触したときの処理
    void OnCollisionEnter(Collision collision)
    {
        //シーンを切り替える
        if (collision.gameObject.tag == "Sphere")
            SceneManager.LoadScene("Goal");
    }
}
