[System.Serializable]
public class StructObject1
{
    public System.String para;
    public System.String[] GlossSeeAlso;

}
[System.Serializable]
public class StructObject2
{
    public System.String SortAs;
    public System.String ID;
    public System.String Acronym;
    public System.String GlossTerm;
    public System.String Abbrev;
    public StructObject1 GlossDef;
    public System.String GlossSee;

}
[System.Serializable]
public class StructObject3
{
    public StructObject2 GlossEntry;

}
[System.Serializable]
public class StructObject4
{
    public System.String title;
    public StructObject3 GlossList;

}
[System.Serializable]
public class StructObject5
{
    public System.String title;
    public StructObject4 GlossDiv;

}
[System.Serializable]
public class StructObject6
{
    public System.String value;
    public System.String onclick;

}
[System.Serializable]
public class StructObject7
{
    public StructObject6[] menuitem;

}
[System.Serializable]
public class StructObject8
{
    public System.String id;
    public System.String value;
    public StructObject7 popup;

}
[System.Serializable]
public class StructObject9
{
    public System.String title;
    public System.String name;
    public System.UInt16 height;
    public System.UInt16 width;

}
[System.Serializable]
public class StructObject10
{
    public System.String src;
    public System.String name;
    public System.Byte hOffset;
    public System.Byte vOffset;
    public System.String alignment;

}
[System.Serializable]
public class StructObject11
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
public class StructObject12
{
    public System.String debug;
    public StructObject9 window;
    public StructObject10 image;
    public StructObject11 text;

}
[System.Serializable]
public class StructObject13
{
    public System.String id;

}
[System.Serializable]
public class StructObject14
{
    public System.String id;
    public System.String label;

}
[System.Serializable]
public class StructObject15
{
    public StructObject13 arg0;
    public StructObject14 arg1;
    public System.Boolean arg2;
    public System.Boolean arg3;
    public System.Boolean arg4;
    public System.Boolean arg5;
    public StructObject14 arg6;
    public StructObject14 arg7;
    public StructObject14 arg8;
    public StructObject13 arg9;
    public StructObject13 arg10;
    public StructObject13 arg11;
    public StructObject14 arg12;
    public StructObject14 arg13;
    public StructObject13 arg14;
    public StructObject14 arg15;
    public StructObject14 arg16;
    public StructObject14 arg17;
    public StructObject14 arg18;
    public StructObject14 arg19;
    public StructObject13 arg20;
    public StructObject14 arg21;

}
[System.Serializable]
public class StructObject16
{
    public System.String header;
    public StructObject15 items;

}
[System.Serializable]
public class StructObject17
{
    public System.Byte y;
    public System.Byte x;
    public System.Byte w;
    public System.Byte h;

}
[System.Serializable]
public class StructObject18
{
    public System.Byte w;
    public System.Byte h;

}
[System.Serializable]
public class StructObject19
{
    public StructObject17 frame;
    public StructObject18 sourceSize;
    public System.Boolean trimmed;
    public System.Boolean rotated;
    public StructObject17 spriteSourceSize;

}
[System.Serializable]
public class StructObject20
{
    public StructObject19 BarGreyBlue2;
    public StructObject19 blueBg2;

}
[System.Serializable]
public class StructObject21
{
    public System.String OtherTerm;

}
[System.Serializable]
public class StructObject22
{
    public System.String para;
    public StructObject21[] GlossSeeAlso;

}
[System.Serializable]
public class StructObject23
{
    public System.String ID;
    public System.String SortAs;
    public System.String GlossTerm;
    public System.String Acronym;
    public System.String Abbrev;
    public StructObject22 GlossDef;
    public StructObject21 GlossSee;

}
[System.Serializable]
public class StructObject24
{
    public StructObject23 GlossEntry;

}
[System.Serializable]
public class StructObject25
{
    public System.String title;
    public StructObject24 GlossList;

}
[System.Serializable]
public class StructObject26
{
    public System.String title;
    public StructObject25 GlossDiv;

}
[System.Serializable]
public class StructObject27
{
    public System.String action;
    public System.String id;

}
[System.Serializable]
public class StructObject28
{
    public System.String header;
    public StructObject27[] item;
    public System.String[] separator;

}
[System.Serializable]
public class StructObject29
{
    public System.Byte name;
    public System.String born;
    public System.String[] part;

}
[System.Serializable]
public class StructObject30
{
    public System.Byte name;
    public System.String[] born;
    public System.String[] part;

}
[System.Serializable]
public class StructObject31
{
    public System.Byte name;
    public System.String born;
    public System.String part;

}
[System.Serializable]
public class StructObject32
{
    public StructObject29 arg0;
    public StructObject29 arg1;
    public StructObject30 arg2;
    public StructObject31 arg3;
    public StructObject30 arg4;
    public StructObject31 arg5;
    public StructObject30 arg6;
    public StructObject30 arg7;
    public StructObject30 arg8;
    public StructObject30 arg9;
    public StructObject30 arg10;
    public StructObject31 arg11;
    public StructObject29 arg12;
    public StructObject31 arg13;
    public StructObject30 arg14;
    public StructObject30 arg15;
    public StructObject31 arg16;
    public StructObject30 arg17;
    public StructObject30 arg18;

}
[System.Serializable]
public class StructObject33
{
    public System.String[] button;
    public StructObject32 step;

}
