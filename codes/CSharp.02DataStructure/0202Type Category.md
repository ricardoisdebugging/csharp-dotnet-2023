(本部分内容主要来自于图解C#)
- 类型
  - 作为面向对象的程序语言，C#是一组类型声明
    > C#的OOP不仅仅是可以创建和使用类而已，其基本的构造、就是类
  - 命名空间是将类相互区分的方式
  - 类是模板，从模板创建出来对象的过程就是实例化
- 数据成员和函数成员
  - 保留了数据
  - 保留了行为
  
---
![类型描述](/CSharp.02DataStructure//Resources/类型分类.png)
- 预定义类型
  - 包括13种[基本类型](/CSharp.02DataStructure/0201Basic%20Type.md)和3种非基本类型
  - 3种非基本类型包括字符串、对象以及动态类型
- 用户定义类型
  - 预定义类型可以直接实例化
  - 而用户定义类型则需要先声明类型，才能实例化
- 类型声明
  - 声明完成两件事情
  1. 定义一个别名
  2. 在栈上分配一块内存空间（此时没有值，只有在初始化或者赋值时才有值；有值才可以使用）
  - 一些类型会在声明时自动初始化，初始化值采用默认值
    - 引用类型为null
    - 数值类型为0
    - 浮点类型（尽管也是引用类型）为0.0
    - 布尔型为false
    - char型为\0

---
- 类型存储方式：堆和栈
- 堆
  - LIFO，先进后出
- 堆
  - 任意存入和移除
  - 通过垃圾回收来关系

---
- 值类型
  - 变量引用的位置就是值在内存中实际存储的位置
  - 将一个变量的值赋值给第二个变量，会在新变量的位置创建原始变量的值的内存副本
  - 值对象的数据会保存在栈里
  - 预定义类型中的**布尔型**以及**整型**，用户定义类型中的**结构类型**以及**枚举类型**都是值类型
- 引用类型
  - 存储指向数据存储的位置的引用
  - 预定义类型中的**非基本类型**、**字节型**以及**浮点型**，用户定义类型中的**类类型**、**接口类型**、**委托类型**以及**数组类型**都是引用类型
  - 数据（不管数据本身是什么类型）存储在堆里，引用存储在栈里

---
- 浅复制和深复制
  - 浅复制（也称浅拷贝）指的是只复制对象，而不将对象背后关联的关系一同复制；深复制（也称深拷贝）则会将对象以及其关联的整个内容都复制。
  - 对于值类型而言，由于其对象只有自己的数据，因此深、浅拷贝的结果一样
  - 对于引用类型而言，浅拷贝只会复制其它数据保存位置的引用，使得拷贝的结果实际是和原来的对象一样、指向相同的数据地址。只有在深拷贝的情况下才会将引用以及引用的数据都复制，得到和原来无关的结果。