using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveMng 
{
    static SaveMng _ins = null;
    public static SaveMng Ins
    {
        get
        {
            if (_ins == null)
                _ins = new SaveMng();
            return _ins;
        }
    }



    public void Save(bool isOn,string a)
    {
        int Val = 0;
        if (isOn)
            Val = 1;
        else
            Val = 0;
        PlayerPrefs.SetInt(a, Val);
    }

    public bool Load(string a)
    {
        int Val = PlayerPrefs.GetInt(a, 0);
        bool isOn;
        if (Val == 0)
            isOn = false;
        else
            isOn = true;
        return isOn;
    }

    //public bool GetCheck(bool isOn)
    //{
    //    bool asdf;
    //    if (isOn)
    //        asdf = true;
    //    else
    //        asdf = false;
    //    return asdf;
    //}
}
