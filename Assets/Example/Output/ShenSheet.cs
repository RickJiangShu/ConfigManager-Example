using System.Collections.Generic;

[System.Serializable]
public class ShenSheet
{
    /// <summary>
    /// 索引
    /// </summary>
    public byte id;

    /// <summary>
    /// 名字
    /// </summary>
    public string name;

    /// <summary>
    /// asdf
    /// </summary>
    public string ctt;


    private static Dictionary<byte, ShenSheet> dictionary = new Dictionary<byte, ShenSheet>();

    /// <summary>
    /// 通过id获取ShenSheet的实例
    /// </summary>
    /// <param name="id">索引</param>
    /// <returns>ShenSheet的实例</returns>
    public static ShenSheet Get(byte id)
    {
        return dictionary[id];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<byte, ShenSheet> GetDictionary()
    {
        return dictionary;
    }
}
