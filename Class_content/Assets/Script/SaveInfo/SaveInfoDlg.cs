using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSaveInfo
{
    public int nBest;
    public int nTotal;
    public int nLastStage;
    public CSaveInfo(int b,int t,int l)
    {
        nBest = b;
        nTotal = t;
        nLastStage = l;
    }
}

public class SStage
{
    public int nStage;
    public int nScore;
}

public class SaveInfoDlg
{
    public List<CSaveInfo> m_SaveInfos = new List<CSaveInfo>();
    public List<SStage> m_SStages = new List<SStage>();

    public void Init()
    {

    }

    public void Save()
    {
        FileStream fs = new FileStream("SaveInfoDlg", FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);

        for (int i = 0; i < m_SaveInfos.Count; i++)
        {
            bw.Write(m_SaveInfos[i].nBest);
            bw.Write(m_SaveInfos[i].nTotal);
            bw.Write(m_SaveInfos[i].nLastStage);
        }
        for (int i = 0; i < m_SStages.Count; i++)
        {
            bw.Write(m_SStages[i].nStage);
            bw.Write(m_SStages[i].nScore);
        }

        fs.Close();
        bw.Close();
    }

    public void Load()
    {
        FileStream fs = new FileStream("SaveInfoDlg", FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fs);



        fs.Close();
        br.Close();
    }
}
