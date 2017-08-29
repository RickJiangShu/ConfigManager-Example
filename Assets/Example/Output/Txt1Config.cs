using System.Collections.Generic;

[System.Serializable]
public class Txt1Config
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
    public byte RandomRatio;

    /// <summary>
    /// 装备部件
    /// </summary>
    public uint EquipType;

    /// <summary>
    /// 装备品质
    /// </summary>
    public byte EquipStar;

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


    private static Dictionary<uint, Txt1Config> dictionary = new Dictionary<uint, Txt1Config>();

    /// <summary>
    /// 通过EquipId获取Txt1Config的实例
    /// </summary>
    /// <param name="EquipId">索引</param>
    /// <returns>Txt1Config的实例</returns>
    public static Txt1Config Get(uint EquipId)
    {
        return dictionary[EquipId];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<uint, Txt1Config> GetDictionary()
    {
        return dictionary;
    }
}
