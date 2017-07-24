using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	// Use this for initialization
    public bool loadByResource = true;

    void Start()
    {
        /*
        SerializableSet set;

        float startTime = Time.realtimeSinceStartup;

        if (loadByResource)
        {
            set = Resources.Load<SerializableSet>("SerializableSet");
            Deserializer.Deserialize(set);

            //卸载内存
            Resources.UnloadUnusedAssets();//Resources卸载内存
        }
        else
        {
            AssetBundle bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/config.ab");
            set = bundle.LoadAsset<SerializableSet>("SerializableSet");
            Deserializer.Deserialize(set);

            //卸载内存
            bundle.Unload(true);//AssetBundle卸载内存
        }

        Debug.Log("解析速度：" + (Time.realtimeSinceStartup - startTime) + "s");

        print(Txt1Sheet.Get(601110).EquipName);//*.txt
        print(Csv2Sheet.Get(210101).name);//*.csv
        print(Json1Json.Get().glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso[0]);//*.json
        print(Xml2Xml.Get().menu.popup.menuitem[2].value);//*.xml
        print(Xls1Sheet.Get(601314).EquipType);//*.xls
        print(Xlsx1Sheet.Get(601213).boxBonus);//*.xlsx
        */
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
