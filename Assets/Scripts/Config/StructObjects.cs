[System.Serializable]
public class StructObject1
{
    public System.Byte name;
    public System.String born;
    public System.String[] part;

}
[System.Serializable]
public class StructObject2
{
    public System.Byte name;
    public System.String[] born;
    public System.String[] part;

}
[System.Serializable]
public class StructObject3
{
    public System.Byte name;
    public System.String born;
    public System.String part;

}
[System.Serializable]
public class StructObject4
{
    public StructObject1 arg0;
    public StructObject1 arg1;
    public StructObject2 arg2;
    public StructObject3 arg3;
    public StructObject2 arg4;
    public StructObject3 arg5;
    public StructObject2 arg6;
    public StructObject2 arg7;
    public StructObject2 arg8;
    public StructObject2 arg9;
    public StructObject2 arg10;
    public StructObject3 arg11;
    public StructObject1 arg12;
    public StructObject3 arg13;
    public StructObject2 arg14;
    public StructObject2 arg15;
    public StructObject3 arg16;
    public StructObject2 arg17;
    public StructObject2 arg18;

}
[System.Serializable]
public class StructObject5
{
    public System.String[] button;
    public StructObject4 step;

}
[System.Serializable]
public class StructObject6
{
    public System.String OtherTerm;

}
[System.Serializable]
public class StructObject7
{
    public System.String para;
    public StructObject6[] GlossSeeAlso;

}
[System.Serializable]
public class StructObject8
{
    public System.String ID;
    public System.String SortAs;
    public System.String GlossTerm;
    public System.String Acronym;
    public System.String Abbrev;
    public StructObject7 GlossDef;
    public StructObject6 GlossSee;

}
[System.Serializable]
public class StructObject9
{
    public StructObject8 GlossEntry;

}
[System.Serializable]
public class StructObject10
{
    public System.String title;
    public StructObject9 GlossList;

}
[System.Serializable]
public class StructObject11
{
    public System.String title;
    public StructObject10 GlossDiv;

}
[System.Serializable]
public class StructObject12
{
    public System.String value;
    public System.String onclick;

}
[System.Serializable]
public class StructObject13
{
    public StructObject12[] menuitem;

}
[System.Serializable]
public class StructObject14
{
    public System.String id;
    public System.String value;
    public StructObject13 popup;

}
[System.Serializable]
public class StructObject15
{
    public System.String title;
    public System.String name;
    public System.UInt16 width;
    public System.UInt16 height;

}
[System.Serializable]
public class StructObject16
{
    public System.String src;
    public System.String name;
    public System.Byte hOffset;
    public System.Byte vOffset;
    public System.String alignment;

}
[System.Serializable]
public class StructObject17
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
public class StructObject18
{
    public System.String debug;
    public StructObject15 window;
    public StructObject16 image;
    public StructObject17 text;

}
[System.Serializable]
public class StructObject19
{
    public System.String action;
    public System.String id;

}
[System.Serializable]
public class StructObject20
{
    public System.String header;
    public StructObject19[] item;
    public System.String[] separator;

}
