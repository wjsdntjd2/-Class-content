using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class ItemText
{
    public int Id = 0;
    public string name = "";
    public int val = 0;
}

public class ParserTestDlg : MonoBehaviour
{
    public Text ResultText = null;
    public Button Load = null;
    public Button Parsing = null;
    public Button Clear = null;
    List<ItemText> ItemTexts = new List<ItemText>();

    private void Start()
    {
        Load.onClick.AddListener(OnClick_Load);
        Parsing.onClick.AddListener(OnClick_Par);
    }

    public void Init()
    {

    }

    void OnClick_Load()
    {
        LoadingTest();
    }

    void OnClick_Par()
    {
        ItemTexts.Clear();
        List<string[]> dataList = CSVParser.Load("TableData/test");

        for (int i = 1; i < dataList.Count; i++)
        {
            string[] data = dataList[i];

            ItemText item = new ItemText();

            item.Id = int.Parse(data[0]);
            item.name = data[1];
            item.val = int.Parse(data[2]);

            ItemTexts.Add(item);
        }
        PrintText();
    }


    void LoadingTest()
    {
        List<string[]> dataList = CSVParser.Load("TableData/test");

        string sResult = "";
        for (int i = 0; i < dataList.Count; i++)
        {
            string[] data = dataList[i];
            sResult += string.Format("{0},{1},{2}\n", data[0], data[1], data[2]);
        }
        ResultText.text = sResult;
    }

    void PrintText()
    {
        StringBuilder Builder = new StringBuilder();
        for (int i = 0; i < ItemTexts.Count; i++)
        {
            ItemText item = ItemTexts[i];
            string str = string.Format("{0}, {1}, {2} \n", item.Id, item.name, item.val);
            Builder.Append(str);
        }
        ResultText.text = Builder.ToString();
    }
}
