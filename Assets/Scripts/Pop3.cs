using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pop3 : MonoBehaviour
{

    public Button btnClose;

    public Button btnGo;

    private void Awake()
    {
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
