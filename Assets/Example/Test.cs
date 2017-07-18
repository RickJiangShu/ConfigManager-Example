using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	// Use this for initialization
    public bool loadByResource = true;

	void Start () {
        /*
        SerializableSet set;
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


        float startTime = Time.realtimeSinceStartup;


        Debug.Log("解析速度：" + (Time.realtimeSinceStartup - startTime) + "s");


        MonsterConfig monsterCfg = MonsterConfig.Get(210102);
        EquipConfig equipCfg = EquipConfig.Get(601110);
        TestTypesConfig typesCfg = TestTypesConfig.Get("1");

        //CSV
        MonsterCSVConfig monsterCSVCfg = MonsterCSVConfig.Get(210103);
        EquipCSVConfig equipCSVCfg = EquipCSVConfig.Get(601111);
        TestTypesCSVConfig typesCSVCfg = TestTypesCSVConfig.Get("1");


        print(monsterCfg.name);
        print(equipCfg.boxBonus);
        print(typesCfg.p15);

        print(monsterCSVCfg.Attack);
        print(equipCSVCfg.EquipId);
        print(typesCSVCfg.p16);

        print(PetConfig.GetDictionary());
        print(PetConfig.GetValues().Length);
        print(PetConfig.GetKeys().Length);
         */
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
