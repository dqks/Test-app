using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

[DataContract]
public class TreeNode : IEnumerable<TreeNode>
{
    [DataMember]
    public Dictionary<string, TreeNode> Сhildren { get; set; }
    [DataMember]
    public string ID;

    [IgnoreDataMember]
    public TreeNode Parent { get; private set; }
    public static List<TreeNode> tests = new List<TreeNode>();

    public TreeNode ()
    {
        Сhildren = new Dictionary<string, TreeNode>();
    }

    public static void addTest (TreeNode test)
    {
        tests.Add(test);
    }

    public static void addTest(TreeNode test, int position)
    {
        tests.Insert(position, test);
    }

    public TreeNode(string id)
    {
        this.ID = id;
        Сhildren = new Dictionary<string, TreeNode>();
    }

    public TreeNode GetChild(string id)
    {
        TreeNode res;
        Сhildren.TryGetValue(id, out res);
        return res;
    }

    public void Add(TreeNode item)
    {
        if (item.Parent != null)
        {
            item.Parent.Сhildren.Remove(item.ID);
        }

        item.Parent = this;
        this.Сhildren.Add(item.ID, item);
    }

    public IEnumerator<TreeNode> GetEnumerator()
    {
        return this.Сhildren.Values.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count
    {
        get { return this.Сhildren.Count; }
    }

    public static void SerializeToXml(List<TreeNode> root, string filePath)
    {
        DataContractSerializer serializer = new DataContractSerializer(typeof(List<TreeNode>));
        using (XmlWriter writer = XmlWriter.Create(filePath))
        {
            serializer.WriteObject(writer, root);
        }
    }

    public static List<TreeNode> DeserializeFromXml(string filePath)
    {
        DataContractSerializer serializer = new DataContractSerializer(typeof(List<TreeNode>));
        using (XmlReader reader = XmlReader.Create(filePath))
        {
            return (List<TreeNode>)serializer.ReadObject(reader);
        }
    }

    public static List<TreeNode> makeTreeNode()
    {
        TreeNode oopTree = new TreeNode("ООП")
                        {
                            new TreeNode("1 уровень")
                            {
                                new TreeNode("RADIOВыберите рассшифровку ООП")
                                {
                                    new TreeNode("Оперативно-объектное программирование"),
                                    new TreeNode("Отраженное объектное программирование"),
                                    new TreeNode("TRUEОбъектно-ориентированное программирование"),

                                } ,
                                new TreeNode("RADIOЧто такое класс?")
                                {
                                    new TreeNode("Класс - это это тип данных, созданный системой на основе системы компьютера"),
                                    new TreeNode("TRUEКласс - это тип данных, созданный пользователем. Он содержит разные свойства и методы, как, например, тип String или Int"),
                                    new TreeNode("Класс - это шаблон для всего"),

                                } ,
                                new TreeNode("CHECKBOXВыберите, какие языки программирования являются ООП:")
                                {
                                    new TreeNode("TRUEJavaScript"),
                                    new TreeNode("C#TRUE"),
                                    new TreeNode("JavaTRUE"),

                                } ,
                                new TreeNode("CHECKBOXВыберите верное утверждение:")
                                {
                                    new TreeNode("TRUEОбъект является продуктом класса"),
                                    new TreeNode("Класс является продуктом объекта"),
                                    new TreeNode("Объект никак не связан с классом"),

                                } ,
                                new TreeNode("RADIOСколько основных принципов есть в ООП:")
                                {
                                    new TreeNode("1 принцип"),
                                    new TreeNode("2 принципа"),
                                    new TreeNode("TRUE3 принципа"),
                                    new TreeNode("Их нет"),

                                }
                            },
                            new TreeNode("2 уровень")
                            {
                                new TreeNode("RADIOЧто такое метод?")
                                {
                                    new TreeNode("TRUEФункция внутри объекта или класса, которая позволяет взаимодействовать с ним или другой частью кода"),
                                    new TreeNode("Процедура обработки данных"),
                                    new TreeNode("Функция, создающая новые объекты"),
                                } ,

                                new TreeNode("RADIOЧто такое конструктор класса?")
                                {
                                    new TreeNode("Метод, который не возвращает значение"),
                                    new TreeNode("то фукнция создания класса"),
                                    new TreeNode("TRUEСпециальный метод в классе, который вызывается при создании нового объекта этого класса"),
                                } ,

                                new TreeNode("CHECKBOXВыберите основные принципы ООП:")
                                {
                                    new TreeNode("TRUEПолиморфизм"),
                                    new TreeNode("Обработка входящих данных"),
                                    new TreeNode("TRUEИнкапсуляция"),
                                    new TreeNode("Ассинхронное выполнение действий"),
                                    new TreeNode("TRUEНаследование"),
                                } ,

                                new TreeNode("RADIOО каком термине идет речь: использование одного и того же метода для обработки различных типов данных")
                                {
                                    new TreeNode("TRUEПолиморфизм"),
                                    new TreeNode("Обработка входящих данных"),
                                    new TreeNode("Инкапсуляция"),
                                    new TreeNode("Ассинхронное выполнение действий"),
                                    new TreeNode("Наследование"),
                                } ,
                                new TreeNode("RADIOПоле это -")
                                {
                                    new TreeNode("переменная, обязательно целочисленного типа или строка, которая характеризует класс"),
                                    new TreeNode("TRUEпеременная, которая характеризует класс"),
                                    new TreeNode("глобальная переменная, доступная во всей программе"),
                                } ,
                            },
                            new TreeNode("3 уровень")
                            {
                                new TreeNode("CHECKBOXУ нас есть класс Человек, какие поля ему следует прописать?")
                                {
                                    new TreeNode("имяTRUE"),
                                    new TreeNode("должность на работе"),
                                    new TreeNode("дата рожденияTRUE"),
                                    new TreeNode("отчество"),
                                    new TreeNode("полTRUE"),
                                } ,

                                new TreeNode("CHECKBOXВыберите один или несколько вариантов ответа:")
                                {
                                    new TreeNode("В классе может быть только один конструктор"),
                                    new TreeNode("TRUEВ классе не может быть два метода с одним названием, одинаковыми параметрами и возвращаемым значением"),
                                    new TreeNode("Каждый класс обязательно должен содержать в себе главный метод"),
                                } ,

                                new TreeNode("RADIOЧто такое геттеры и сеттеры?")
                                {
                                    new TreeNode("Общие методы для всех классов, которые выдают и задают системные требования"),
                                    new TreeNode("Методы для присваивания значения другим методам"),
                                    new TreeNode("TRUEМетоды, которые присваивают и получают значения полям"),
                                } ,
                                new TreeNode("RADIOЧто такое абстрактный класс?")
                                {
                                    new TreeNode("Класс, который человек придумал в голове"),
                                    new TreeNode("TRUEБазовый класс, который не предполагает создания объектов"),
                                    new TreeNode("Класс, который имеет абсрактные методы"),
                                } ,
                                new TreeNode("RADIOЧто такое наследование?")
                                {
                                    new TreeNode("TRUEМеханимзм, который позволяет наследовать одними классами и свойствами поведение других классов для расширения"),
                                    new TreeNode("Механизм, который позволяет передать имя класса другому"),
                                    new TreeNode("Механизм передачи информации от одного класс к другому"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения:")
                                {
                                    new TreeNode("TRUEПри наследовании класс может быть базовым для многих классов"),
                                    new TreeNode("При создании объекта от статического класса должен также быть реализован конструктор без аргументов"),
                                    new TreeNode("В проекте обязательно должно быть более 1 точки входа"),
                                    new TreeNode("TRUEИспользование интерфейса при описании класса является необязательным"),
                                } ,
                            }
                        };

        TreeNode csTree = new TreeNode("C#")
                        {
                            new TreeNode("1 уровень")
                            {
                                new TreeNode("RADIOC# это:")
                                {
                                    new TreeNode("TRUEОбъектно-ориентированный язык программирования"),
                                    new TreeNode("Функциональный язык программирования"),
                                    new TreeNode("ООП с чертами фукнционального языка программирования"),
                                } ,
                                new TreeNode("RADIOC# это регистрозависимый язык программирования?")
                                {
                                    new TreeNode("TRUEДа"),
                                    new TreeNode("Нет"),
                                } ,
                                new TreeNode("RADIOЧто такое метод?")
                                {
                                    new TreeNode("Конструкция, присущая классу"),
                                    new TreeNode("TRUEИменнованный блок кода, который выполняет некоторые действия"),
                                    new TreeNode("Системные ячейки памяти, которые выполняют определеннй действия"),
                                } ,
                                new TreeNode("RADIOС помощью какого ключевого слова можно передавать неопределенное количество параметров?")
                                {
                                    new TreeNode("TRUEparams"),
                                    new TreeNode("..."),
                                    new TreeNode("array"),
                                    new TreeNode("arrayLike"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения:")
                                {
                                    new TreeNode("В C# можно изменять строки напрямую"),
                                    new TreeNode("TRUEВ C# нельзя изменять строки напрямую"),
                                    new TreeNode("Параметры в методы всегда передаются по ссылке"),
                                    new TreeNode("TRUEДля того, чтобы передать параметры по ссылке необходимо использовать ключевое слово ref"),
                                } ,
                            },
                            new TreeNode("2 уровень")
                            {
                                new TreeNode("RADIOВыберите верное утверждение:")
                                {
                                    new TreeNode("TRUEОписанием объекта является класс, а объект представляет экземпляр этого класса"),
                                    new TreeNode("Описанием класса является объект, а класс представляет экземпляр этого объекта"),
                                } ,
                                new TreeNode("RADIOМожно ли создать класс без определения конструктора?")
                                {
                                    new TreeNode("Да"),
                                    new TreeNode("TRUEНет"),
                                } ,
                               new TreeNode("RADIOСколько в классе может быть максимум конструкторов?")
                                {
                                    new TreeNode("1"),
                                    new TreeNode("2"),
                                    new TreeNode("3"),
                                    new TreeNode("TRUEНеограниченное количество"),
                                } ,
                                new TreeNode("RADIOЧто позволяет выполнить декомпозицию объекта на отдельные части?")
                                {
                                    new TreeNode("Деструктор"),
                                    new TreeNode("TRUEДеконструктор"),
                                    new TreeNode("Декомпилятор"),
                                    new TreeNode("Деинициализатор"),
                                } ,
                                new TreeNode("RADIOЧто такое перегрузка?")
                                {
                                    new TreeNode("TRUEВозможность создавать один и тот же метод, но с разными параметрами и/или разным возвращаемым значением"),
                                    new TreeNode("Большое количество использование одного и того же метода, что приводит к ошибкам компиляции"),
                                    new TreeNode("Дополнение возможностей метода"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения")
                                {
                                    new TreeNode("TRUEОтличие модификатора доступа private от protected в том, что второй может наследоваться"),
                                    new TreeNode("Отличие модификатора доступа private от protected в том, что второй не может наследоваться"),
                                    new TreeNode("TRUEПреимущество свойств заключается в том что они не занимают память"),
                                    new TreeNode("Недостатком свойств явлсяется то, что они занимают повышенный объем памяти"),
                                } ,
                            },
                            new TreeNode("3 уровень")
                            {
                                new TreeNode("RADIOЧто такое индексаторы?")
                                {
                                    new TreeNode("Возможность обращаться к классам по индексу"),
                                    new TreeNode("TRUEВозможность обращаться к объектам по индексу"),
                                    new TreeNode("Возможность обращаться к полям класс по индексу"),
                                } ,
                                new TreeNode("RADIOС помощью какого ключевого слова можно указать наследование:")
                                {
                                    new TreeNode("Base"),
                                    new TreeNode("TRUE:"),
                                    new TreeNode("Inherit"),
                                } ,
                                new TreeNode("CHECKBOXЧто такое абстрактный класс?")
                                {
                                    new TreeNode("Класс, продуманный в голове"),
                                    new TreeNode("TRUEКласс, от которого нельзя создавать объекты"),
                                    new TreeNode("TRUEКласс, определенный с помощью ключевого слова abstract"),
                                } ,
                                new TreeNode("RADIOВерно ли утверждение, что от класса object можно создать объект любого класса?")
                                {
                                    new TreeNode("TRUEДа"),
                                    new TreeNode("Нет"),
                                } ,
                                new TreeNode("CHECKBOXВ чем основное отличие коллекций от массивов?")
                                {
                                    new TreeNode("Расширенный функционал"),
                                    new TreeNode("TRUEНеограниченный размер коллекции"),
                                    new TreeNode("TRUEРеализация стандартных структур данных (очередь, стек и т.д.)"),
                                } ,
                            }
                        };

        TreeNode cppTree = new TreeNode("C++")
                        {
                            new TreeNode("1 уровень")
                            {
                                new TreeNode("RADIOЯзык C++ компилируемый или интрерпретируемый язык программирования?")
                                {
                                    new TreeNode("TRUEКомплирируемый"),
                                    new TreeNode("Интрепретируемый"),
                                } ,
                                new TreeNode("RADIOКакая функция обязательно должна быть в программе на C++")
                                {
                                    new TreeNode("Main"),
                                    new TreeNode("General"),
                                    new TreeNode("TRUEmain"),
                                } ,
                                new TreeNode("RADIOКакую директиву необходимо подключить для ввода и вывода в консоль?")
                                {
                                    new TreeNode("stream"),
                                    new TreeNode("istream"),
                                    new TreeNode("ostream"),
                                    new TreeNode("TRUEiostream"),
                                } ,
                                new TreeNode("RADIOС помощью какой инструкции можно подключить пространство имен?")
                                {
                                    new TreeNode("#include"),
                                    new TreeNode("TRUEusing"),
                                    new TreeNode("#using"),
                                    new TreeNode("include"),
                                } ,
                                new TreeNode("RADIOЧто обозначает приставка unsigned у числовых типов?")
                                {
                                    new TreeNode("TRUEЧисло без знака \"минус\""),
                                    new TreeNode("Число со знаком \"минус\""),
                                    new TreeNode("Число со знаком и без знака \"минус\""),
                                } ,
                            },
                            new TreeNode("2 уровень")
                            {
                                new TreeNode("RADIOВ конструкции switch чтобы избежать выполнения case/default нужно ли ставить break в конце каждого оператора?")
                                {
                                    new TreeNode("TRUEДа"),
                                    new TreeNode("Нет"),
                                } ,
                                new TreeNode("RADIOСколько циклов необходимо для вставки элемента в массив?")
                                {
                                    new TreeNode("Один"),
                                    new TreeNode("TRUEДва"),
                                    new TreeNode("Нет"),
                                } ,
                                new TreeNode("RADIOСколько циклов необходимо для удаления элемента из массива?")
                                {
                                    new TreeNode("Один"),
                                    new TreeNode("TRUEДва"),
                                    new TreeNode("Нет"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения:")
                                {
                                    new TreeNode("TRUEС помощью операции & можно получить адрес некоторого объекта"),
                                    new TreeNode("С помощью операции & можно установить указатель"),
                                    new TreeNode("С помощью операции * можно получить адрес некоторого объекта"),
                                    new TreeNode("TRUEС помощью операции * можно установить указатель"),
                                } ,
                                new TreeNode("RADIOКакое значение лежит в неинициализированном указателе?")
                                {
                                    new TreeNode("TRUE\"случайный\" адрес"),
                                    new TreeNode("Нулевой указатель"),
                                    new TreeNode("Нуль"),
                                    new TreeNode("nullptr"),
                                } ,
                            },
                            new TreeNode("3 уровень")
                            {
                                new TreeNode("RADIOКакое значение лежит в неинициализированном указателе?")
                                {
                                    new TreeNode("TRUEОператор &"),
                                    new TreeNode("Оператор *"),
                                    new TreeNode("Никакой, все параметры итак передаются по ссылке"),
                                } ,
                                new TreeNode("RADIOВерно ли утверждение, что если функция принимает в качестве параметра массив, то фактически в эту функцию передается указатель на первый элемент массива")
                                {
                                    new TreeNode("TRUEДа"),
                                    new TreeNode("Нет"),
                                } ,
                                new TreeNode("RADIOКак называется функция, которая вызывает саму себя?")
                                {
                                    new TreeNode("Процедура"),
                                    new TreeNode("TRUEРекурсия"),
                                    new TreeNode("Цикличная функция"),
                                } ,
                                new TreeNode("RADIOЧто содержит в себе файл с расширением .h?")
                                {
                                    new TreeNode("TRUEОбъявление функции"),
                                    new TreeNode("Главный файл"),
                                    new TreeNode("Определение функции"),
                                    new TreeNode("Используемые директивы"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения:")
                                {
                                    new TreeNode("TRUEТип ifstream необходим для чтения с файла"),
                                    new TreeNode("Тип ifstream необходим для записи в файл"),
                                    new TreeNode("Тип ofstream необходим для чтения с файла"),
                                    new TreeNode("TRUEТип ofstream необходим для записи в файл"),
                                    new TreeNode("TRUEТип fstream совмещает запись и чтение"),
                                } ,
                                new TreeNode("RADIOЧто такое вектор?")
                                {
                                    new TreeNode("Объект типа ключ-значение, ключи которого представляют собой любые типы данных"),
                                    new TreeNode("Массив уникальных элементов"),
                                    new TreeNode("TRUEКонтейнер, который содержит коллекцию объектов одного типов"),
                                } ,
                            }
                        };

        TreeNode jsTree = new TreeNode("JavaScript")
                        {
                            new TreeNode("1 уровень")
                            {
                                new TreeNode("CHECKBOXДля чего создан JavaScript?")
                                {
                                    new TreeNode("Для создания сайтов"),
                                    new TreeNode("TRUEДля управления внешним видом и содержимым HTML-документов"),
                                    new TreeNode("Для серверной работы с сайтом"),
                                } ,
                                new TreeNode("RADIOJavaScript это -")
                                {
                                    new TreeNode("TRUEИнтерпретируемый язык программирования"),
                                    new TreeNode("Компилируемый язык программирования"),
                                } ,
                                new TreeNode("RADIOКакой тип типизации в JavaScript")
                                {
                                    new TreeNode("Строготипизированный"),
                                    new TreeNode("TRUEАвтоматическая типизация"),
                                    new TreeNode("Автоматическая типизация, но если необохидмо, можно подключить строгую типизацию"),
                                } ,
                                new TreeNode("RADIOРасшифруйте аббревиатуру DOM")
                                {
                                    new TreeNode("TRUEDocument Object Model"),
                                    new TreeNode("Digital Object Model"),
                                    new TreeNode("Document Object Mastery"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения:")
                                {
                                    new TreeNode("директиву \"use strict\" можно отменить"),
                                    new TreeNode("TRUEРасшифровка NaN - Not a number"),
                                    new TreeNode("Конкатенация строк в JavaScript может производиться с помощью \"+\" и \".\" (точки)"),
                                    new TreeNode("TRUEJavaScript не предоставляет низкоуровневый доступ к памяти или процессору"),
                                } ,
                            },

                            new TreeNode("2 уровень")
                            {
                                new TreeNode("CHECKBOXКакие типы определения фукнций существуют?")
                                {
                                    new TreeNode("TRUEFunction Declaration"),
                                    new TreeNode("TRUEFunction Expression"),
                                    new TreeNode("TRUEСтрелочные фукнции"),
                                    new TreeNode("Методная функция"),
                                    new TreeNode("TRUENFE"),
                                } ,
                                new TreeNode("CHECKBOXЧто делает метод объекта Document querySelector?")
                                {
                                    new TreeNode("Возвращает все элементы на странице по id"),
                                    new TreeNode("Возвращает все элементы на странице по классу"),
                                    new TreeNode("Возвращает первый элемент на странице по id или классу"),
                                    new TreeNode("TRUEВозвращает элемент на странице по селектору"),
                                } ,
                                new TreeNode("RADIOВыполнится ли сразу функция setTimeout(() => console.log(\"Вопрос\"), 0)?")
                                {
                                    new TreeNode("Да"),
                                    new TreeNode("TRUEНет"),
                                    new TreeNode("Нет, код выдаст ошибку"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения:")
                                {
                                    new TreeNode("TRUEСтрелочные функции не имеют this"),
                                    new TreeNode("Стрелочные функции имеют this, но по умолчанию он равен undefined"),
                                    new TreeNode("Set отличается от обычного массива продвинутым функционалом использования, большим количеством методов"),
                                    new TreeNode("Метод массивов map изменяет изначальный массив и ничего не возвращает"),
                                    new TreeNode("TRUEИспользование функции eval не является хорошей практикой"),
                                } ,
                                new TreeNode("RADIOМогут ли у функции быть свойства, в объектном понимании (например, functionName.property)")
                                {
                                    new TreeNode("TRUEДа"),
                                    new TreeNode("Нет"),
                                } ,
                            },

                            new TreeNode("3 уровень")
                            {
                                new TreeNode("RADIOКак называется процесс доступа к переменным до их определения?")
                                {
                                    new TreeNode("TDZ"),
                                    new TreeNode("TRUEHoisting"),
                                    new TreeNode("Промис"),
                                } ,
                                new TreeNode("RADIOЧто возвращает функция fetch?")
                                {
                                    new TreeNode("Тело запроса"),
                                    new TreeNode("TRUEОбъект Response"),
                                    new TreeNode("Тело запроса в виде JSON"),
                                } ,
                                new TreeNode("CHECKBOXКакие есть виды пропоганации события")
                                {
                                    new TreeNode("TRUEВсплытие"),
                                    new TreeNode("TRUEПогружение"),
                                    new TreeNode("TRUEПерехват"),
                                    new TreeNode("Распространение"),
                                } ,
                                new TreeNode("RADIOВыберите верное утверждение про строку x = y = z = 100:")
                                {
                                    new TreeNode("Код вызовет ошибку"),
                                    new TreeNode("x будет равно 100, а все остальные переменные undefined"),
                                    new TreeNode("z будет равно 100, а все остальные переменные undefined"),
                                    new TreeNode("y будет равно 100, а все остальные переменные undefined"),
                                    new TreeNode("TRUEx, y, и z будут равны 100"),
                                } ,
                                new TreeNode("RADIOКакой прием разработки позволяет организовать пропоганация")
                                {
                                    new TreeNode("Всплытие"),
                                    new TreeNode("Погружение"),
                                    new TreeNode("Перехват"),
                                    new TreeNode("TRUEДелегирование"),
                                } ,
                                new TreeNode("CHECKBOXВыберите верные утверждения про события")
                                {
                                    new TreeNode("TRUEПри быстром движении мыши события НЕ будут возникать на промежуточных элементах"),
                                    new TreeNode("При быстром движении мыши события будут возникать на промежуточных элементах"),
                                    new TreeNode("TRUEmouseover/out возникают, когда происходит переход с родительского элемента на потомка"),
                                    new TreeNode("mouseover/out НЕ возникают, когда происходит переход с родительского элемента на потомка"),
                                    new TreeNode("TRUEmouseenter/leave генерируются, когда курсор переходит на элемент в целом или уходит с него"),
                                } ,
                            }
                        };
        tests.Add(oopTree);
        tests.Add(csTree);
        tests.Add(cppTree);
        tests.Add(jsTree);
        return tests;
    }
}