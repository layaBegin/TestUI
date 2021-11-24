using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pop1 : MonoBehaviour
{

    public Button btnClose;

    public Button btnGo;

    public Transform uiPos;
    public Transform popPos;

    private UIManager uiManager;

    private void Awake()
    {
        UIManager[] uiManagerArray = (UIManager[])Object.FindObjectsOfType(typeof(UIManager));
        if (uiManagerArray.Length == 1)
        {
            uiManager = uiManagerArray[0];
        }
        btnClose.onClick.AddListener(onBtnClose);
        btnGo.onClick.AddListener(onBtnGoUI1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onBtnClose()
    {
        uiManager.colsePop(this.gameObject);
    }

    void onBtnGoUI1()
    {
        //UIManager.openUI("ui1",this.uiPos);
    }
}
