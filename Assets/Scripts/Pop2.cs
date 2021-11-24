using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pop2 : MonoBehaviour
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
        btnGo.onClick.AddListener(onBtnGoUI2);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onBtnClose()
    {
        uiManager.colsePop(this.gameObject);
    }

    void onBtnGoUI2()
    {
        Destroy(this.gameObject);
        uiManager.openUI("ui1");
    }
}
