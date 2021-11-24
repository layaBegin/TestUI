using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pop1 : MonoBehaviour
{

    public Button btnClose;

    public Button btnGo;

    public Transform uiPos;

    private void Awake()
    {
        btnClose.onClick.AddListener(onBtnClose);
        btnGo.onClick.AddListener(onBtnGoUI1);
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

    void onBtnGoUI1()
    {
        UIManager.openUI("ui1",this.uiPos);
    }
}
