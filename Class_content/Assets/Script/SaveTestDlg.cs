using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTestDlg : MonoBehaviour
{
    public Toggle BGM;
    public Toggle SFX;
    public Button SaveBtn;
    public Button LoadBtn;
    
    private void Start()
    {
        SaveBtn.onClick.AddListener(SaveOnclick);
        LoadBtn.onClick.AddListener(LoadOnclick);
    }

    public void SaveOnclick()
    {
        SaveMng.Ins.Save(BGM.isOn,"BGM");
        SaveMng.Ins.Save(SFX.isOn,"SFX");
    }

    public void LoadOnclick()
    {
        BGM.isOn = SaveMng.Ins.Load("BGM");
        SFX.isOn = SaveMng.Ins.Load("SFX");
    }
}
