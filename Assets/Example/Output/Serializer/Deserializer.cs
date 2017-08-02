public class Deserializer
{
    public static void Deserialize(SerializableSet set)
    {
       
        for (int i = 0, l = set.Csv1s.Length; i < l; i++)
        {
            Csv1Sheet.GetDictionary().Add(set.Csv1s[i].EquipId, set.Csv1s[i]);
        }
       
        for (int i = 0, l = set.Csv2s.Length; i < l; i++)
        {
            Csv2Sheet.GetDictionary().Add(set.Csv2s[i].id, set.Csv2s[i]);
        }
       
        for (int i = 0, l = set.Csv3s.Length; i < l; i++)
        {
            Csv3Sheet.GetDictionary().Add(set.Csv3s[i].id, set.Csv3s[i]);
        }
       
        for (int i = 0, l = set.Csv4s.Length; i < l; i++)
        {
            Csv4Sheet.GetDictionary().Add(set.Csv4s[i].id, set.Csv4s[i]);
        }
       
        for (int i = 0, l = set.Txt1s.Length; i < l; i++)
        {
            Txt1Sheet.GetDictionary().Add(set.Txt1s[i].EquipId, set.Txt1s[i]);
        }
       
        for (int i = 0, l = set.Txt2s.Length; i < l; i++)
        {
            Txt2Sheet.GetDictionary().Add(set.Txt2s[i].id, set.Txt2s[i]);
        }
       
        for (int i = 0, l = set.Txt3s.Length; i < l; i++)
        {
            Txt3Sheet.GetDictionary().Add(set.Txt3s[i].id, set.Txt3s[i]);
        }
       
        for (int i = 0, l = set.Txt4s.Length; i < l; i++)
        {
            Txt4Sheet.GetDictionary().Add(set.Txt4s[i].id, set.Txt4s[i]);
        }
       
        for (int i = 0, l = set.Xlsx1s.Length; i < l; i++)
        {
            Xlsx1Sheet.GetDictionary().Add(set.Xlsx1s[i].EquipId, set.Xlsx1s[i]);
        }
       
        for (int i = 0, l = set.Xlsx2s.Length; i < l; i++)
        {
            Xlsx2Sheet.GetDictionary().Add(set.Xlsx2s[i].EquipId, set.Xlsx2s[i]);
        }

        Json1Json.instance = set.Json1;
        Json2Json.instance = set.Json2;
        Json3Json.instance = set.Json3;
        Json4Json.instance = set.Json4;
        Json5Json.instance = set.Json5;
        Xml1Xml.instance = set.Xml1;
        Xml2Xml.instance = set.Xml2;
        Xml3Xml.instance = set.Xml3;
        Xml4Xml.instance = set.Xml4;
        Xml5Xml.instance = set.Xml5;

    }
}
