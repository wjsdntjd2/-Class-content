using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAsset 
{
    public int Id = 0;
}

public class AssetItem : CAsset
{
    public int ItemType = 0;
    public string PrefabName = "";
    public int Val = 0;
    public string Desc = "";
}

public class AssetStage : CAsset
{
    public float    FireDelayTime   = 0;
    public float    bulletSpeed     = 0;
    public int      KeepTime        = 0;
    public int      PlayerHP        = 0;
    public int      bulletAttack    = 0;
    public int      itemAppearDelay = 0;
    public int      itemKeepTime    = 0;
    public int      TurretCount     = 0;
}