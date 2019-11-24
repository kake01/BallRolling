using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Fast : MonoBehaviour
{
//    public GameObject titlescene;

    void Start()
    {
   //     this.titlescene = GameObject.Find("TitleGameObject");
    }
    
    public void OnValueChange()
    {
        Debug.Log("早い");
        //titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(8, 5);
    }
}
