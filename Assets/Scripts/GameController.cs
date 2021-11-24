using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public Transform uiPos;
    public Transform popPos;


    private void Awake()
    {
        GameObject pop1 = Resources.Load<GameObject>("Prefabs/pop1");
        GameObject pop2 = Resources.Load<GameObject>("Prefabs/pop2");
        GameObject pop3 = Resources.Load<GameObject>("Prefabs/pop3");
        UIManager.Instance.popUIList.Add(pop1);
        UIManager.Instance.popUIList.Add(pop2);
        UIManager.Instance.popUIList.Add(pop3);
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject pop1 = Instantiate(UIManager.Instance.popUIList[0]);

        pop1.transform.SetParent(popPos);
        identityPos(pop1);
        Pop1 scriptPop1 = pop1.GetComponent<Pop1>();
        scriptPop1.uiPos = uiPos;
        UIManager.Instance.popUIList.RemoveAt(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void identityPos(GameObject obj)
    {
        obj.transform.localPosition = new Vector3(0, 0, 0);
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.transform.localScale = new Vector3(1, 1, 1);
    }
}
