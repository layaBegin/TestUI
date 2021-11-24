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
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onBtnClose()
    {
        Debug.Log("====µã»÷¹Ø±Õ°´Å¥");
        DestroyObject(this.transform.gameObject);
    }
}
