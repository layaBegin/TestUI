using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public UIManager uiManager;


    private void Awake()
    {
        UIManager[] uiManagerArray = (UIManager[])Object.FindObjectsOfType(typeof(UIManager));
        if (uiManagerArray.Length == 1)
        {
            uiManager = uiManagerArray[0];
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        //GameObject pop1 = Instantiate(UIManager.Instance.popUIList[0]);
        //UIManager.openPopUI(pop1, popPos);
        //Pop1 scriptPop1 = pop1.GetComponent<Pop1>();
        //scriptPop1.uiPos = uiPos;
        //scriptPop1.popPos = popPos;
        uiManager.addPopUI("pop1");
        uiManager.addPopUI("pop2");
        uiManager.addPopUI("pop3");
        uiManager.openPopUI();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void identityPos(GameObject obj)
    {
        obj.transform.localPosition = new Vector3(0, 0, 0);
        obj.transform.localRotation = Quaternion.identity;
        obj.transform.localScale = new Vector3(1, 1, 1);
    }
}
