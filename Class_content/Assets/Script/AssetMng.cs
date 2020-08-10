using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetMng
{
    static AssetMng _ins = null;
    public static AssetMng Ins
    {
        get
        {
            if (_ins == null)
                _ins = new AssetMng();
            return _ins;
        }
    }

    public List<AssetItem> AssetItems = new List<AssetItem>();
    public List<AssetStage> AssetStages = new List<AssetStage>();
    public List<string[]> ItemdataList;
    public List<string[]> StagedataList;

    public void Init()
    {
        Init_Item("TableData/item");
        Init_Stage("TableData/stage");
    }

    public void Init_Item(string s)
    {
        AssetItems.Clear();

        ItemdataList = CSVParser.Load(s);

        for (int i = 1; i < ItemdataList.Count; i++)
        {
            string[] data = ItemdataList[i];

            AssetItem item = new AssetItem();

            item.Id = int.Parse(data[0]);
            item.ItemType = int.Parse(data[1]);
            item.PrefabName = data[2];
            item.Val = int.Parse(data[3]);
            item.Desc = data[4];

            AssetItems.Add(item);
        }
    }

    public void Init_Stage(string s)
    {
        AssetStages.Clear();

        StagedataList = CSVParser.Load(s);

        for (int i = 1; i < StagedataList.Count; i++)
        {
            string[] data = StagedataList[i];

            AssetStage Stage = new AssetStage();

            Stage.Id = int.Parse(data[0]);
            Stage.FireDelayTime = float.Parse(data[1]);
            Stage.bulletSpeed = float.Parse(data[2]);
            Stage.KeepTime = int.Parse(data[3]);
            Stage.PlayerHP = int.Parse(data[4]);
            Stage.bulletAttack = int.Parse(data[5]);
            Stage.itemAppearDelay = int.Parse(data[6]);
            Stage.itemKeepTime = int.Parse(data[7]);
            Stage.TurretCount = int.Parse(data[8]);
            AssetStages.Add(Stage);
        }
    }

    public AssetStage GetAssetStage(int id)
    {
        if (id > 0 && id <= AssetStages.Count)
        {
            return AssetStages[id - 1];
        }
        return null;
    }
}
