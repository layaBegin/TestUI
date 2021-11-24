using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Transform uiPos;
    public Transform popPos;

    //当前已经打开的界面，在栈里面的界面
    private List<GameObject> uiStack = new List<GameObject>();
    //缓存的界面，从栈里面打开的
    private Dictionary<string, GameObject> cacheUIDic = new Dictionary<string, GameObject>();
    //顺序弹窗
    private List<GameObject> popUIList = new List<GameObject>();

    public GameObject GetCacheUI(string uiName)
    {
        GameObject go = cacheUIDic[uiName];
        if (go != null)
        {
            return go;
        }
        return null;
    }
    public void addPopUI(string pfbName )
    {
        GameObject obj = Resources.Load<GameObject>("Prefabs/" + pfbName);
        this.popUIList.Add(obj);
    }
    
    public  void openUI(string uiName,Transform parent)
    {
        string url = "Prefabs/" + uiName;
        GameObject ui =  Resources.Load<GameObject>(url);
        ui.transform.SetParent(parent);
        ui.transform.localPosition = new Vector3(0,0,0);
        ui.transform.localRotation = Quaternion.identity;
        ui.transform.localScale = new Vector3(1,1,1);
    }

    public  void openPopUI()
    {
        if (this.popUIList.Count > 0)
        {
            GameObject obj = Instantiate(this.popUIList[0]);

            obj.transform.SetParent(popPos);
            obj.transform.localPosition = new Vector3(0, 0, 0);
            obj.transform.localRotation = Quaternion.identity;
            obj.transform.localScale = new Vector3(1, 1, 1);
            this.popUIList.RemoveAt(0);
        }
        
    }

    //关闭弹窗，如果有继续弹窗
    public  void colsePop(GameObject obj)
    {
        Destroy(obj);
        if (this.popUIList.Count > 0)
            this.openPopUI();

    }
}
