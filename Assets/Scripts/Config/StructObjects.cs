[System.Serializable]
public class StructObject1
{
    public System.String OtherTerm;

}
[System.Serializable]
public class StructObject2
{
    public System.String para;
    public StructObject1[] GlossSeeAlso;

}
[System.Serializable]
public class StructObject3
{
    public System.String ID;
    public System.String SortAs;
    public System.String GlossTerm;
    public System.String Acronym;
    public System.String Abbrev;
    public StructObject2 GlossDef;
    public StructObject1 GlossSee;

}
[System.Serializable]
public class StructObject4
{
    public StructObject3 GlossEntry;

}
[System.Serializable]
public class StructObject5
{
    public System.String title;
    public StructObject4 GlossList;

}
[System.Serializable]
public class StructObject6
{
    public System.String title;
    public StructObject5 GlossDiv;

}
[System.Serializable]
public class StructObject7
{
    public System.String value;
    public System.String onclick;

}
[System.Serializable]
public class StructObject8
{
    public StructObject7[] menuitem;

}
[System.Serializable]
public class StructObject9
{
    public System.String id;
    public System.String value;
    public StructObject8 popup;

}
[System.Serializable]
public class StructObject10
{
    public System.String title;
    public System.String name;
    public System.UInt16 width;
    public System.UInt16 height;

}
[System.Serializable]
public class StructObject11
{
    public System.String src;
    public System.String name;
    public System.Byte hOffset;
    public System.Byte vOffset;
    public System.String alignment;

}
[System.Serializable]
public class StructObject12
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
public class StructObject13
{
    public System.String debug;
    public StructObject10 window;
    public StructObject11 image;
    public StructObject12 text;

}
