using System.Collections.Generic;

[System.Serializable]
public class Txt3Sheet
{
    /// <summary>
    /// 宠物ID
    /// </summary>
    public uint id;

    /// <summary>
    /// 宠物名称
    /// </summary>
    public string name;

    /// <summary>
    /// 宠物图片
    /// </summary>
    public string icon;

    /// <summary>
    /// 升星消耗
    /// </summary>
    public int upgradeCost;

    /// <summary>
    /// 页签
    /// </summary>
    public byte sence;

    /// <summary>
    /// 界面动作库
    /// </summary>
    public string[] detailAnime;

    /// <summary>
    /// 下一级ID
    /// </summary>
    public uint nextLevel;

    /// <summary>
    /// 宠物技能说明
    /// </summary>
    public string skillDetails;

    /// <summary>
    /// 攻击距离
    /// </summary>
    public byte atkRange;

    /// <summary>
    /// 升级消耗
    /// </summary>
    public uint feedCost;

    /// <summary>
    /// 伤害系数(百分比)
    /// </summary>
    public byte atkCoefficient;

    /// <summary>
    /// 攻击动作
    /// </summary>
    public int atkAnime;

    /// <summary>
    /// 星级
    /// </summary>
    public byte star;

    /// <summary>
    /// 属性集合
    /// </summary>
    public string property;

    /// <summary>
    /// 技能集合
    /// </summary>
    public string[] skill;

    /// <summary>
    /// 获取途径
    /// </summary>
    public byte achieve;

    /// <summary>
    /// 怪物形象
    /// </summary>
    public string modelID;

    /// <summary>
    /// 怪物尺寸
    /// </summary>
    public float modelSize;

    /// <summary>
    /// 攻击特效名称
    /// </summary>
    public string effectName;

    /// <summary>
    /// 攻击特效持续时间
    /// </summary>
    public float effectTime;

    /// <summary>
    /// 界面动作宽度
    /// </summary>
    public uint animeWidth;

    /// <summary>
    /// 界面动作高度
    /// </summary>
    public uint animeHeight;

    /// <summary>
    /// 获取途径参数
    /// </summary>
    public uint achieveNum;

    /// <summary>
    /// 未解锁显示文本提示
    /// </summary>
    public string unlockDetail;

    /// <summary>
    /// 界面显示的怪物尺寸
    /// </summary>
    public float modelUISize;

    /// <summary>
    /// 品质
    /// </summary>
    public byte quality;

    /// <summary>
    /// 移动速度
    /// </summary>
    public float MoveSpeed;


    private static Dictionary<uint, Txt3Sheet> dictionary = new Dictionary<uint, Txt3Sheet>();

    /// <summary>
    /// 通过id获取Txt3Sheet的实例
    /// </summary>
    /// <param name="id">索引</param>
    /// <returns>Txt3Sheet的实例</returns>
    public static Txt3Sheet Get(uint id)
    {
        return dictionary[id];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<uint, Txt3Sheet> GetDictionary()
    {
        return dictionary;
    }
}
