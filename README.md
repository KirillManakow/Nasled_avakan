# Nasled_avakan
# LESSON_2

## Начало работы

Для работы с программой необходимо скачать и разархивировать папку с репозитория, а далее запустить программу по данному пути **\Nasled_avakan\LESSON_2.exe**

### Работа в программе

Что нужно для установки программного обеспечения и как его установить

![тут должно быть фото выполненной работы](https://sun9-44.userapi.com/impg/VCgXboMD4cs4UK_9sSMdQkoIjJKKJ8IWTxWMDA/BeugF0CIK6w.jpg?size=297x453&quality=96&sign=d33e3b65b5df7b87f5659d92fb4e2373&type=album)

### Рекомандции по изменению программы



Первый шаг для изменения.
Для изменения программу нужно будет открыть не немного другому пути а конкретнно **\Nasled_avakan\LESSON_2.sln**.
Первое что нас встретит будет массив Клиентов ,который в основном и меняеться.

``` C#
 static void Main(string[] args)
    {
     Client[] clientDataBase = new Client[]
        {
            new Investor("Сорокин", 250178.597m, 20.15),
            new Investor("Манаков", 12178.867m, 18.75),
            new Investor("Власова", 50.50m,20),
            new Creditor("Мухин",  121780.867m, 18.75, 120000),
            new Creditor("Орешкова",  12178.867m, 18.75, 578.89m),
            new Organization("ООО'ЗОЧЕМ'", 123456785, 7894623.7834m),
            new Organization("ООО'ЗАТЕМ'", 456456785, 7894623.7834m)
        };

            foreach (Client client in clientDataBase)
            {
                client.PrintInfo();
                Console.WriteLine();
            }
            Console.Read();
    }
```
Если вы хотите поменять код, то непобохимо внутри массива ,который располагается с низу вставить нужные вамм параметры.
```c#
Client[] clientDataBase = new Client[]
        {
            ....
            ....
            ....
            ...
        };
```
В программе есть три типа клиентов, со своими параметрами:
* Investor
  +  Фамилия,
  +  Размер вклада,
  +  Процент по вкладу
* Creditor 
  +  Фамилия
  +  Размер кредита
  +  Процент по кредику
  +  Остаток долга
* Organization
  +  Название
  +  Номер счёта
  +  Сумма по счету

## Авторы

* **KirillManakow** - [Ссылка на гит](https://github.com/KirillManakow),
  + [ссылка на проект](https://github.com/KirillManakow/Nasled_avakan/tree/master):