using System.Collections.Generic;

[System.Serializable]
public class TestTypesConfig
{
    /// <summary>
    /// 测试所有类型
    /// </summary>
    public string id;

    /// <summary>
    /// 布尔
    /// </summary>
    public bool p1;

    /// <summary>
    /// uint8
    /// </summary>
    public byte p2;

    /// <summary>
    /// uint16
    /// </summary>
    public ushort p3;

    /// <summary>
    /// uint32
    /// </summary>
    public uint p4;

    /// <summary>
    /// int8
    /// </summary>
    public sbyte p5;

    /// <summary>
    /// int16
    /// </summary>
    public short p6;

    /// <summary>
    /// int32
    /// </summary>
    public int p7;

    /// <summary>
    /// long
    /// </summary>
    public long p8;

    /// <summary>
    /// ulong
    /// </summary>
    public ulong p9;

    /// <summary>
    /// float
    /// </summary>
    public float p10;

    /// <summary>
    /// double
    /// </summary>
    public double p11;

    /// <summary>
    /// string
    /// </summary>
    public string p12;

    /// <summary>
    /// int数组
    /// </summary>
    public int[] p13;

    /// <summary>
    /// uint数组
    /// </summary>
    public uint[] p14;

    /// <summary>
    /// string数组
    /// </summary>
    public string[] p15;

    /// <summary>
    /// bool数组
    /// </summary>
    public bool[] p16;


    private static Dictionary<string, TestTypesConfig> dictionary = new Dictionary<string, TestTypesConfig>();

    /// <summary>
    /// 通过id获取TestTypesConfig的实例
    /// </summary>
    /// <param name="id">索引</param>
    /// <returns>TestTypesConfig的实例</returns>
    public static TestTypesConfig Get(string id)
    {
        return dictionary[id];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<string, TestTypesConfig> GetDictionary()
    {
        return dictionary;
    }

    /// <summary>
    /// 获取所有键
    /// </summary>
    /// <returns>所有键</returns>
    public static string[] GetKeys()
    {
        int count = dictionary.Keys.Count;
        string[] keys = new string[count];
        dictionary.Keys.CopyTo(keys,0);
        return keys;
    }

    /// <summary>
    /// 获取所有实例
    /// </summary>
    /// <returns>所有实例</returns>
    public static TestTypesConfig[] GetValues()
    {
        int count = dictionary.Values.Count;
        TestTypesConfig[] values = new TestTypesConfig[count];
        dictionary.Values.CopyTo(values, 0);
        return values;
    }
}
