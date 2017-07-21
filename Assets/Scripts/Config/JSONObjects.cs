[System.Serializable]
public class JSONObject1
{
    public System.String para;
    public System.String[] GlossSeeAlso;

}
[System.Serializable]
public class JSONObject2
{
    public System.String SortAs;
    public System.String ID;
    public System.String Acronym;
    public System.String GlossTerm;
    public System.String Abbrev;
    public JSONObject1 GlossDef;
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
    public System.String title;
    public JSONObject3 GlossList;

}
[System.Serializable]
public class JSONObject5
{
    public System.String title;
    public JSONObject4 GlossDiv;

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
    public System.String id;
    public System.String value;
    public JSONObject7 popup;

}
[System.Serializable]
public class JSONObject9
{
    public System.String title;
    public System.String name;
    public System.UInt16 height;
    public System.UInt16 width;

}
[System.Serializable]
public class JSONObject10
{
    public System.String src;
    public System.String name;
    public System.Byte hOffset;
    public System.Byte vOffset;
    public System.String alignment;

}
[System.Serializable]
public class JSONObject11
{
    public System.String data;
    public System.Byte size;
    public System.String style;
    public System.String name;
    public System.Byte hOffset;
    public System.Byte vOffset;
    public System.String alignment;
    public System.String onMouseUp;

}
[System.Serializable]
public class JSONObject12
{
    public System.String debug;
    public JSONObject9 window;
    public JSONObject10 image;
    public JSONObject11 text;

}
[System.Serializable]
public class JSONObject13
{
    public System.String id;

}
[System.Serializable]
public class JSONObject14
{
    public System.String id;
    public System.String label;

}
[System.Serializable]
public class JSONObject15
{
    public JSONObject13 arg0;
    public JSONObject14 arg1;
    public System.Boolean arg2;
    public System.Boolean arg3;
    public System.Boolean arg4;
    public System.Boolean arg5;
    public JSONObject14 arg6;
    public JSONObject14 arg7;
    public JSONObject14 arg8;
    public JSONObject13 arg9;
    public JSONObject13 arg10;
    public JSONObject13 arg11;
    public JSONObject14 arg12;
    public JSONObject14 arg13;
    public JSONObject13 arg14;
    public JSONObject14 arg15;
    public JSONObject14 arg16;
    public JSONObject14 arg17;
    public JSONObject14 arg18;
    public JSONObject14 arg19;
    public JSONObject13 arg20;
    public JSONObject14 arg21;

}
[System.Serializable]
public class JSONObject16
{
    public System.String header;
    public JSONObject15 items;

}
[System.Serializable]
public class JSONObject17
{
    public System.Byte y;
    public System.Byte x;
    public System.Byte w;
    public System.Byte h;

}
[System.Serializable]
public class JSONObject18
{
    public System.Byte w;
    public System.Byte h;

}
[System.Serializable]
public class JSONObject19
{
    public JSONObject17 frame;
    public JSONObject18 sourceSize;
    public System.Boolean trimmed;
    public System.Boolean rotated;
    public JSONObject17 spriteSourceSize;

}
[System.Serializable]
public class JSONObject20
{
    public JSONObject19 BarGreyBlue2;
    public JSONObject19 blueBg2;

}
