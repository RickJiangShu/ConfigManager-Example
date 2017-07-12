using System.Collections.Generic;

[System.Serializable]
public class EquipConfig
{
    /// <summary>
    /// 装备ID
    /// </summary>
    public uint EquipId;

    /// <summary>
    /// 装备图标
    /// </summary>
    public string EquipIcon;

    /// <summary>
    /// 装备名称
    /// </summary>
    public string EquipName;

    /// <summary>
    /// 随机权值
    /// </summary>
    public uint RandomRatio;

    /// <summary>
    /// 装备部件
    /// </summary>
    public uint EquipType;

    /// <summary>
    /// 装备品质
    /// </summary>
    public uint EquipStar;

    /// <summary>
    /// 装备属性
    /// </summary>
    public string EquipStat;

    /// <summary>
    /// 主属性
    /// </summary>
    public uint MainStat;

    /// <summary>
    /// 主属性成长系数
    /// </summary>
    public float StatRatio;

    /// <summary>
    /// 主属性基础值
    /// </summary>
    public float StatBase;

    /// <summary>
    /// 名称材质处理
    /// </summary>
    public uint NameShader;

    /// <summary>
    /// 粒子特效
    /// </summary>
    public string Particles;

    /// <summary>
    /// 粒子特效参数
    /// </summary>
    public string ParticlesPara;

    /// <summary>
    /// 武器模型
    /// </summary>
    public string Model;

    /// <summary>
    /// 宝箱系数
    /// </summary>
    public float boxBonus;


    private static Dictionary<uint, EquipConfig> dictionary = new Dictionary<uint, EquipConfig>();

    /// <summary>
    /// 通过EquipId获取EquipConfig的实例
    /// </summary>
    /// <param name="EquipId">索引</param>
    /// <returns>EquipConfig的实例</returns>
    public static EquipConfig Get(uint EquipId)
    {
        return dictionary[EquipId];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<uint, EquipConfig> GetDictionary()
    {
        return dictionary;
    }

    /// <summary>
    /// 获取所有键
    /// </summary>
    /// <returns>所有键</returns>
    public static uint[] GetKeys()
    {
        int count = dictionary.Keys.Count;
        uint[] keys = new uint[count];
        dictionary.Keys.CopyTo(keys,0);
        return keys;
    }

    /// <summary>
    /// 获取所有实例
    /// </summary>
    /// <returns>所有实例</returns>
    public static EquipConfig[] GetValues()
    {
        int count = dictionary.Values.Count;
        EquipConfig[] values = new EquipConfig[count];
        dictionary.Values.CopyTo(values, 0);
        return values;
    }
}
