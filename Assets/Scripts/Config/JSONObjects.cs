[System.Serializable]
public class JSONObject1
{
    public System.String[] GlossSeeAlso;
    public System.String para;

}
[System.Serializable]
public class JSONObject2
{
    public JSONObject1 GlossDef;
    public System.String ID;
    public System.String SortAs;
    public System.String GlossTerm;
    public System.String Acronym;
    public System.String Abbrev;
    public System.String GlossSee;

}
[System.Serializable]
public class JSONObject3
{
    public JSONObject2 GlossEntry;

}
[System.Serializable]
public class JSONObject4
{
    public JSONObject3 GlossList;
    public System.String title;

}
[System.Serializable]
public class JSONObject5
{
    public JSONObject4 GlossDiv;
    public System.String title;

}
[System.Serializable]
public class JSONObject6
{
    public System.String value;
    public System.String onclick;

}
[System.Serializable]
public class JSONObject7
{
    public JSONObject6[] menuitem;

}
[System.Serializable]
public class JSONObject8
{
    public JSONObject7 popup;
    public System.String id;
    public System.String value;

}
[System.Serializable]
public class JSONObject9
{
    public System.String title;
    public System.String name;
    public System.UInt16 width;
    public System.UInt16 height;

}
[System.Serializable]
public class JSONObject10
{
    public System.String src;
    public System.String name;
    public System.String alignment;
    public System.Byte hOffset;
    public System.Byte vOffset;

}
[System.Serializable]
public class JSONObject11
{
    public System.String data;
    public System.String style;
    public System.String name;
    public System.String alignment;
    public System.String onMouseUp;
    public System.Byte size;
    public System.Byte hOffset;
    public System.Byte vOffset;

}
[System.Serializable]
public class JSONObject12
{
    public JSONObject9 window;
    public JSONObject10 image;
    public JSONObject11 text;
    public System.String debug;

}
[System.Serializable]
public class JSONObject13
{
    public System.Byte x;
    public System.Byte y;
    public System.Byte w;
    public System.Byte h;

}
[System.Serializable]
public class JSONObject14
{
    public System.Byte w;
    public System.Byte h;

}
[System.Serializable]
public class JSONObject15
{
    public JSONObject13 frame;
    public JSONObject13 spriteSourceSize;
    public JSONObject14 sourceSize;
    public System.Boolean rotated;
    public System.Boolean trimmed;

}
[System.Serializable]
public class JSONObject16
{
    public JSONObject15 BarGreyBlue2;
    public JSONObject15 blueBg2;

}
