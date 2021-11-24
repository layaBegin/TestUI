using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildUI : MonoBehaviour
{

    public Button btn;

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
        btn.onClick.AddListener(onBtnClose);
    }

    void onBtnClose()
    {
        uiManager.closeUI(this.transform.parent);
    }
}
