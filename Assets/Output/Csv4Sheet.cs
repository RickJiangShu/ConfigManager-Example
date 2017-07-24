using System.Collections.Generic;

[System.Serializable]
public class Csv4Sheet
{
    /// <summary>
    /// 测试所有类型
    /// </summary>
    public byte id;

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
    public byte p3;

    /// <summary>
    /// uint32
    /// </summary>
    public byte p4;

    /// <summary>
    /// int8
    /// </summary>
    public byte p5;

    /// <summary>
    /// int16
    /// </summary>
    public sbyte p6;

    /// <summary>
    /// int32
    /// </summary>
    public sbyte p7;

    /// <summary>
    /// long
    /// </summary>
    public sbyte p8;

    /// <summary>
    /// ulong
    /// </summary>
    public ushort p9;

    /// <summary>
    /// float
    /// </summary>
    public uint p10;

    /// <summary>
    /// double
    /// </summary>
    public float p11;

    /// <summary>
    /// string
    /// </summary>
    public float p12;

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


    private static Dictionary<byte, Csv4Sheet> dictionary = new Dictionary<byte, Csv4Sheet>();

    /// <summary>
    /// 通过id获取Csv4Sheet的实例
    /// </summary>
    /// <param name="id">索引</param>
    /// <returns>Csv4Sheet的实例</returns>
    public static Csv4Sheet Get(byte id)
    {
        return dictionary[id];
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<byte, Csv4Sheet> GetDictionary()
    {
        return dictionary;
    }
}
