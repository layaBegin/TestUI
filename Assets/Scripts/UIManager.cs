using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UIManager();
            }
            return instance;
        }
    }

    public List<GameObject> popUIList = new List<GameObject>();

    
    public static void openUI(string uiName,Transform parent)
    {
        string url = "Prefabs/" + uiName;
        GameObject ui =  Resources.Load<GameObject>(url);
        ui.transform.SetParent(parent);
        ui.transform.localPosition = new Vector3(0,0,0);
        ui.transform.localRotation = Quaternion.identity;
        ui.transform.localScale = new Vector3(1,1,1);
    }

}
