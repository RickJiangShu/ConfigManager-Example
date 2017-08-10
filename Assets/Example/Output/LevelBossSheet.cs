using System.Collections.Generic;

[System.Serializable]
public class LevelBossSheet
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


    private static Dictionary<byte, LevelBossSheet> dictionary = new Dictionary<byte, LevelBossSheet>();

    /// <summary>
    /// 通过id获取LevelBossSheet的实例
    /// </summary>
    /// <param name="id">索引</param>
    /// <returns>LevelBossSheet的实例</returns>
    public static LevelBossSheet Get(byte id)
    {
        return dictionary[id];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<byte, LevelBossSheet> GetDictionary()
    {
        return dictionary;
    }
}
