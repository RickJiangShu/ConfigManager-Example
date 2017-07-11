public class Deserializer
{
    public static void Deserialize(SerializableSet set)
    {
        for (int i = 0, l = set.Equips.Length; i < l; i++)
        {
            EquipConfig.dict.Add(set.Equips[i].EquipId, set.Equips[i]);
        }
        for (int i = 0, l = set.Monsters.Length; i < l; i++)
        {
            MonsterConfig.dict.Add(set.Monsters[i].id, set.Monsters[i]);
        }
        for (int i = 0, l = set.TestTypess.Length; i < l; i++)
        {
            TestTypesConfig.dict.Add(set.TestTypess[i].id, set.TestTypess[i]);
        }

    }
}
