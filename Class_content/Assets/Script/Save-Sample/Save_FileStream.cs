using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save_FileStream 
{
    public int i = 0;
    public float f = 0;
    public string s = "123123";

    static Save_FileStream _ins = null;
    public static Save_FileStream Ins
    {
        get
        {
            if (_ins == null)
                _ins = new Save_FileStream();
            return _ins;
        }
    }

    public void Save()
    {
        FileStream fs = new FileStream("23", FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);

        bw.Write(i);
        bw.Write(f);
        bw.Write(s);

        fs.Close();
        bw.Close();
    }

    public void Load()
    {
        FileStream fs = new FileStream("23", FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fs);

        br.ReadInt32();
        br.ReadSingle();
        br.ReadString();

        fs.Close();
        br.Close();
    }
}
