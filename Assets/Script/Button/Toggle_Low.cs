using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Low : MonoBehaviour
{
    //  public GameObject titlescene;

    void Start()
    {
        //    titlescene = GameObject.Find("TitleGameObject");
    }

    public void OnValueChange()
    {
        Debug.Log("遅い");
        //        titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(2, 4);
    }
}
