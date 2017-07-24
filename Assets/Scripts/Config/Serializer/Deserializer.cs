public class Deserializer
{
    public static void Deserialize(SerializableSet set)
    {
       
        for (int i = 0, l = set.Equips.Length; i < l; i++)
        {
            EquipSheet.GetDictionary().Add(set.Equips[i].EquipId, set.Equips[i]);
        }


    }
}
