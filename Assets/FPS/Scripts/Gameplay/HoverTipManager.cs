using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class HoverTipManager : MonoBehaviour
{
    public TextMesh tipText;
    public RectTransform tipWindow;

    public static Action<string, Vector2> OnMouseHover;
    public static Action OnMouseLoseFocus;

    private void OnEnable(){
        OnMouseHover += ShowTip;
        OnMouseLoseFocus += HideTip;
    }

    private void OnDisable(){
        OnMouseHover -= ShowTip;
        OnMouseLoseFocus -= HideTip;
    }

    // Start is called before the first frame update
    void Start()
    {
        HideTip();
    }

    private void ShowTip(string tip, Vector2 mousePos){
        tipText.text = tip;
        tipWindow.sizeDelta = new Vector2();

        tipWindow.gameObject.SetActive(true);
        tipWindow.transform.position = new Vector2(mousePos.x + tipWindow.sizeDelta.x * 2, mousePos.y);
    }

    private void HideTip(){
        tipText.text = default;
        tipWindow.gameObject.SetActive(false);
    }

}
