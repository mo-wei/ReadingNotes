# OOTV杯超级模式大赛(具体总节见书29章)

对这本书的所有模式进行一个总结，并且对不同的模式分一下类

![常见模式总和](picture/第二十九章/常见模式总和.png)

## 创建型模式

- 抽象工厂模式：提供一个创建一系列或相关依赖对象的接口，而无需指定它们具体的类
- 建造者模式：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示
- 工厂方法模式：定义一个用于创建对象的接口，让子类决定实例化哪一个类，工厂模式使一个类的实例化延迟到其子类
- 原型模式：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象
- 单例模式：保证一个类仅有一个实例，并提供一个访问它的全局访问点

## 结构型模式

- 适配器模式：将一个类的接口转换成客户希望的另外一个接口。使得原本由于接口不兼容而不能一起工作的那些类可以一起工作
- 桥接模式：将抽象部分与它的实现部分分离，使它们都可以独立地变化
- 组合模式：将对象组合成树形结构以表示‘部分-整体’的层次结构，组合模式使得用户对单个对象和组合对象具有一致性
- 装饰模式：动态地给一个对象添加一些额外的职责。就增加功能来说，装饰模式相比生成子类更加灵活
- 外观模式：为子系统中的一组接口提供一个一致的界面，外观模式定义了一个高层接口，这个接口使得这一子类系统更加容易使用
- 享元模式：运用共享技术有效地支持大量细粒度的对象
- 代理模式：为其他对象提供一种代理以控制对这个对象的访问

## 行为型模式一

- 观察者模式：定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并被自动更新
- 模板方法模式：定义一个操作的算法骨架，而将一些步骤延迟到子类中，模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤
- 命令模式：将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化：可以对请求排队或记录请求日志，以及支持可撤销的操作
- 状态模式：允许一个对象在其内部状态改变时改变它的行为，让对象看起来似乎修改了它的类
- 职责链模式：使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系。将这些对象连城一条链，并沿着这条链传递该请求，直到有一个对象处理它为止

## 行为型模式二

- 解释器模式：给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子
- 中介者模式：用一个中介对象来封装一系列的对象交互。中介者使各对象不需要显式的相互引用，从而使其耦合松散，而且可以独立地改变它们之间的交互
- 访问者模式：表示一个作用于某对象结构中的各元素的操作。它使你可以在不该变各个元素的类的前提下定义作用于这些元素的新操作
- 策略模式：定义一系列算法，把它们一个个封装起来，并且使它们可相互替换。本模式使得算法可独立于使用它的客户而变化
- 备忘录模式：不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可以将该对象恢复到原先保存的状态
- 迭代器模式：提供一种方法顺序访问一个聚合对象中各个元素，而又不暴露该对象的内部表示