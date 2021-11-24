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
    
    public  void openUI(string uiName)
    {
        string url = "Prefabs/" + uiName;
        GameObject ui =  Resources.Load<GameObject>(url);
        GameObject obj = Instantiate(ui);
        obj.transform.SetParent(uiPos);
        obj.transform.localPosition = new Vector3(0,0,0);
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.localScale = new Vector3(1,1,1);
        RectTransform rectT = obj.transform.GetComponent<RectTransform>();
        //rectT.rect.xMin =  0.0f ;
        uiStack.Add(obj);
    }

    public void closeUI(Transform parent)
    {
        if (uiStack.Count <= 0) return;
        GameObject obj = uiStack[uiStack.Count - 1];
        uiStack.Remove(obj);
        Destroy(obj);

        if (parent != null) {

        }
        else if (this.popUIList.Count > 0)
        {
            this.openPopUI();
        }

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
