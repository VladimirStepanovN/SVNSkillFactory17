# SVNSkillFactory17
## Задание 7.2.4
Измените свойство Counter так, чтобы его можно было переопределить в классе DerivedClass.
Переопределите данное свойство, ограничив занесения в него чисел меньше 0.
```console
class BaseClass 
{
  public int Counter 
  {
    get;
    set;
  }
}

class DerivedClass: BaseClass 
{
}
```