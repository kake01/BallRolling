using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_VeryFast : MonoBehaviour
{
   // public GameObject titlescene;
    
    void Start()
    {
    //    this.titlescene = GameObject.Find("TitleGameObject");
    }
    
    public void OnValueChange(bool ischecked)
    {
        Debug.Log("めっさ早い");
//        titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(18, 5);
    }
}