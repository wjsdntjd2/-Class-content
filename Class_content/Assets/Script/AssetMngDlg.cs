using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssetMngDlg : MonoBehaviour
{
    public Button ParsingBtn;
    public Button ClearBtn;
    public Text Result;

    void Init()
    {
        AssetMng.Ins.Init();
    }

    private void Start()
    {
        Init();
        ParsingBtn.onClick.AddListener(ParsingOnclick);
        ClearBtn.onClick.AddListener(ClearOnClick);
    }

    void ParsingOnclick()
    {
        string sResult = "";
        for (int i = 0; i < AssetMng.Ins.ItemdataList.Count; i++)
        {
            string[] data = AssetMng.Ins.ItemdataList[i];
            sResult += string.Format("{0},{1},{2},{3},{4}\n", data[0], data[1], data[2], data[3], data[4]);
        }
        Result.text = sResult;
    }

    void ClearOnClick()
    {
        AssetMng.Ins.GetAssetStage(1);
    }
}
