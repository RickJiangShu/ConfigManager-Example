# 表格格式
以列为属性，以行为一项；<br>
第1行为**注释**；<br>
第2行为**数据类型**<br>
第3行为**字段标识符**<br>
第4行及以下为各项配置<br>
![](https://raw.githubusercontent.com/RickJiangShu/ConfigManager-Example/master/Poster/p3.jpg "")<br>
<br>

# 支持的数据类型
| 配置类型 | 对应C#类型  | 取值范围 |
| :------------: |:---------------:| :-----:|
|bool|bool|0、false、False、False 都为否，其他为是|
|byte、uint8|byte|0 ~ 255|
|ushort、uint16|ushort|0 ~ 65,535|
|uint、uint32|uint|0 ~ 4,294,967,295|
|ulong、uint64|ulong|0 ~ 18,446,744,073,709,551,615|
|sbyte、int8|sbyte|-128 ~ 127|
|short、int16|short|-32,768 ~ 32,767|
|int、int32|int|-2,147,483,648 ~ 2,147,483,647|
|long、int64|long|-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807|
|float|float|-3.4 × 10^38 ~ +3.4 × 10^38|
|double|double|±5.0 × 10^−324 ~ ±1.7 × 10^308|
|string|string|Any|

并支持以上基础类型的所有**数组类型**。<br>
例如：字符串数组类型是string[]，值是Hello,World<br>
