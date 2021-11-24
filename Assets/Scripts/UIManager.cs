using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Transform uiPos;
    public Transform popPos;

    //��ǰ�Ѿ��򿪵Ľ��棬��ջ����Ľ���
    private List<GameObject> uiStack = new List<GameObject>();
    //����Ľ��棬��ջ����򿪵�
    private Dictionary<string, GameObject> cacheUIDic = new Dictionary<string, GameObject>();
    //˳�򵯴�
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

    //�رյ���������м�������
    public  void colsePop(GameObject obj)
    {
        Destroy(obj);
        if (this.popUIList.Count > 0)
            this.openPopUI();

    }
}
