using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class StartButton : MonoBehaviour
{
    public GameObject titlescene;

    void Start()
    {
        titlescene = GameObject.Find("TitleGameObject");
    }
    
    public void OnClick()
    {
        titlescene.GetComponent<TitleSceneScript>().ChangeScene();
    }
}
