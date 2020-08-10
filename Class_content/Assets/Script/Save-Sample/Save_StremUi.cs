using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save_StremUi : MonoBehaviour
{
    public Text ResultText;
    public Button SaveBtn;
    public Button LoadBtn;
    public Button ClearBtn;

    public int asd;
    public int asdf = 50;

    void Start()
    {
        SaveBtn.onClick.AddListener(SaveOnClick);
        LoadBtn.onClick.AddListener(LoadOnClick);
        ClearBtn.onClick.AddListener(Clearnclick);
    }

    void SaveOnClick()
    {
       Save_FileStream.Ins.Save();
    }
    
    void LoadOnClick()
    {
        Save_FileStream.Ins.Load();
        ResultText.text = string.Format("{0}, {1}, {2}", Save_FileStream.Ins.i, Save_FileStream.Ins.f, Save_FileStream.Ins.s);
    }

    void Clearnclick()
    {
        ResultText.text = "Result";
    }
}
