using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save_Stream_Dlg : MonoBehaviour
{
    public Text ResultText;
    public Button SaveBtn;
    public Button LoadBtn;
    public Button ClearBtn;

    Save_FileStream_02 Save_ = new Save_FileStream_02();

    void Start()
    {
        Save_.Init();
        SaveBtn.onClick.AddListener(SaveOnClick);
        LoadBtn.onClick.AddListener(LoadOnClick);
        ClearBtn.onClick.AddListener(Clearnclick);
    }

    void SaveOnClick()
    {
        Save_.Save();
    }

    void LoadOnClick()
    {
        int nCount = Save_.Stdunts.Count;

        Save_.Load();

        string sResult = "";

        for (int i = 0; i < nCount; i++)
        {
            sResult += string.Format("{0}, {1}, {2} \n", Save_.Stdunts[i].Id, Save_.Stdunts[i].Name, Save_.Stdunts[i].Score);
        }
        ResultText.text = sResult;
    }

    void Clearnclick()
    {
        ResultText.text = "Result";
    }
}
