using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Normal : MonoBehaviour
{
//    public GameObject titlescene;

    void Start()
    {
      //  this.titlescene = GameObject.Find("TitleGameObject");
    }

    public void OnValueChange()
    {
        Debug.Log("普通");
//        titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(4, 5);
    }
}
