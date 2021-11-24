using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI1 : MonoBehaviour
{

    public Button btn;
    public Button btnClose;

    private UIManager uiManager;

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
        btn.onClick.AddListener(openChild);
        btnClose.onClick.AddListener(closeChild);
    }

    void openChild()
    {
        uiManager.openUI("childui1");
    }

    void closeChild()
    {
        uiManager.closeUI(null);
    }
}
