using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Stdunt
{
    public int Id = 0;
    public string Name = "";
    public int Score = 0;
    public Stdunt(int i, string s, int sc)
    {
        Id = i;
        Name = s;
        Score = sc;
    }
}



public class Save_FileStream_02
{
    public List<Stdunt> Stdunts = new List<Stdunt>();

    public void Save()
    {
        FileStream fs = new FileStream("asdf", FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);

        for (int i = 0; i < Stdunts.Count; i++)
        {
            bw.Write(Stdunts[i].Id);
            bw.Write(Stdunts[i].Name);
            bw.Write(Stdunts[i].Score);
        }

        fs.Close();
        bw.Close();
    }

    public void Init()
    {
        Stdunts.Clear();
        Stdunts.Add(new Stdunt(1, "123", 100));
        Stdunts.Add(new Stdunt(2, "456", 60));
        Stdunts.Add(new Stdunt(3, "789", 0));
    }

    public void Load()
    {
        try
        {
            int nCount = Stdunts.Count;

            Stdunts.Clear();

            FileStream fs = new FileStream("asdf", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            for (int i = 0; i < nCount; i++)
            {
                int idx = br.ReadInt32();
                string name = br.ReadString();
                int score = br.ReadInt32();

                Stdunt Test = new Stdunt(idx, name, score);

                Stdunts.Add(Test);
            }
            fs.Close();
            br.Close();
        }
        catch(Exception e)
        {
            Debug.Log(e.ToString());
        }
    }
}
