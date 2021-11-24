using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pop3 : MonoBehaviour
{

    public Button btnClose;

    public Button btnGo;
    private UIManager uiManager;

    private void Awake()
    {
        UIManager[] uiManagerArray = (UIManager[])Object.FindObjectsOfType(typeof(UIManager));
        if (uiManagerArray.Length == 1)
        {
            uiManager = uiManagerArray[0];
        }
        btnClose.onClick.AddListener(onBtnClose);
        btnGo.onClick.AddListener(onBtnGoUI3);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onBtnClose()
    {
        Debug.Log("====µã»÷¹Ø±Õ°´Å¥3");
        uiManager.colsePop(this.gameObject);

    }

    void onBtnGoUI3()
    {
        Destroy(this.gameObject);
        uiManager.openUI("ui1");
    }
}
