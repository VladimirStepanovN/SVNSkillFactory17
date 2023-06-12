# SVNSkillFactory17
## Задание 7.1.10
Для класса DerivedClass создайте 2 конструктора: один, принимающий 2 параметра — name и description,
второй — принимающий 3 параметра name, description и counter.
Старайтесь написать оптимальный вариант с учетом полученных знаний.
```console
class BaseClass 
{
  protected string Name;

  public BaseClass(string name) 
  {
    Name = name;
  }
}

class DerivedClass: BaseClass 
{
  public string Description;

  public int Counter;
}
```