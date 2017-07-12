public class Deserializer
{
    public static void Deserialize(SerializableSet set)
    {
       
        for (int i = 0, l = set.Equips.Length; i < l; i++)
        {
            EquipConfig.GetDictionary().Add(set.Equips[i].EquipId, set.Equips[i]);
        }
       
        for (int i = 0, l = set.EquipCSVs.Length; i < l; i++)
        {
            EquipCSVConfig.GetDictionary().Add(set.EquipCSVs[i].EquipId, set.EquipCSVs[i]);
        }
       
        for (int i = 0, l = set.Monsters.Length; i < l; i++)
        {
            MonsterConfig.GetDictionary().Add(set.Monsters[i].id, set.Monsters[i]);
        }
       
        for (int i = 0, l = set.MonsterCSVs.Length; i < l; i++)
        {
            MonsterCSVConfig.GetDictionary().Add(set.MonsterCSVs[i].id, set.MonsterCSVs[i]);
        }
       
        for (int i = 0, l = set.Pets.Length; i < l; i++)
        {
            PetConfig.GetDictionary().Add(set.Pets[i].id, set.Pets[i]);
        }
       
        for (int i = 0, l = set.PetCSVs.Length; i < l; i++)
        {
            PetCSVConfig.GetDictionary().Add(set.PetCSVs[i].id, set.PetCSVs[i]);
        }
       
        for (int i = 0, l = set.TestTypess.Length; i < l; i++)
        {
            TestTypesConfig.GetDictionary().Add(set.TestTypess[i].id, set.TestTypess[i]);
        }
       
        for (int i = 0, l = set.TestTypesCSVs.Length; i < l; i++)
        {
            TestTypesCSVConfig.GetDictionary().Add(set.TestTypesCSVs[i].id, set.TestTypesCSVs[i]);
        }

    }
}
