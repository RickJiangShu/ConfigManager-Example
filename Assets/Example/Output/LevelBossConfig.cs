using System.Collections.Generic;

[System.Serializable]
public class LevelBossConfig
{
    /// <summary>
    /// 关卡id
    /// </summary>
    public byte id;

    /// <summary>
    /// 关卡名
    /// </summary>
    public string name;

    /// <summary>
    /// Boss
    /// </summary>
    public byte bossId;


    private static Dictionary<byte, LevelBossConfig> dictionary = new Dictionary<byte, LevelBossConfig>();

    /// <summary>
    /// 通过id获取LevelBossConfig的实例
    /// </summary>
    /// <param name="id">索引</param>
    /// <returns>LevelBossConfig的实例</returns>
    public static LevelBossConfig Get(byte id)
    {
        return dictionary[id];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<byte, LevelBossConfig> GetDictionary()
    {
        return dictionary;
    }
}
