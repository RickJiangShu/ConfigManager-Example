/*
 * Author:  Rick
 * Create:  2017/7/14 14:39:31
 * Email:   rickjiangshu@gmail.com
 * Follow:  https://github.com/RickJiangShu
 */
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

/// <summary>
/// TestJsonParse
/// </summary>
public class TestJsonParse : MonoBehaviour
{
    public TextAsset textAsset;

    public TextAsset regexText;
    // Use this for initialization
    void Start()
    {
        string content = textAsset.text;

        XmlDocument document = new XmlDocument();

        Debug.Log(XEX1Xml.ins.glossary.GlossDiv.GlossList.GlossEntry.GlossSee.OtherTerm);
    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable]
    public class MyData
    {
        public string[] GlossSeeAlso;
    }


    [System.Serializable]
    public class Data
    {
        public object Name;
    }

    //Json Regex Fork:https://stackoverflow.com/questions/2583472/regex-to-validate-json
    //替换" 为 ""
    //private string regexString = "\"([^\"\\\\\\\\]*|\\\\\\\\[\"\\\\\\\\bfnrt\\/]|\\\\\\\\u[0-9a-f]{4})*\"";
    private const string regexString = @"""([^""\\\\]*|\\\\[""\\\\bfnrt\/]|\\\\u[0-9a-f]{4})*""";

    private const string regexObject = @"\{(?:\s*" + regexString + @"\s*:(?1)(?:,\s*" + regexString + @"\s*:(?1))*)?\s*\}";
}
