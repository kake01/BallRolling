using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;

public class SubmitButton : MonoBehaviour
{
    public GameObject titlescene;


    //連携するGameObject
    public ToggleGroup toggle_group;

    public void Start() => titlescene = GameObject.Find("TitleGameObject");


    public void OnClick()
    {
        //checkの付いた値を渡す
        string selectedLabel = toggle_group.ActiveToggles().First().GetComponentsInChildren<Text>().First(t => t.name == "Label").text;

        switch (selectedLabel)
        {
            case "test1":
                Debug.Log("遅い");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(2, 4);
                break;
            case "test2":
                Debug.Log("普通");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(4, 5);
                break;
            case "test3":
                Debug.Log("早い");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(8, 5);
                break;
            case "test4":
                Debug.Log("めっさ早い");
                titlescene.GetComponent<TitleSceneScript>().ChangeSpeed(18, 5);
                break;
            default:
                Debug.Log("エラー");
                break;
        }
        titlescene.GetComponent<TitleSceneScript>().ChangeScene();
    }
}