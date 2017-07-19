using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	// Use this for initialization
    public bool loadByResource = true;

	void Start () {

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
        */

         
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
